using ConsoleApp1.Context;
using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace ConsoleApp1;

public class CheckinValidator : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        var db = new MyDbContext(new DbContextOptions<MyDbContext>());

        var bookingIds = db.Prenclis.Where(p => p.Modificato == 3).Select(p => p.Codopz).Distinct().ToList();
        Console.WriteLine($"Tutte le prenotazioni: {bookingIds.Count}.");
        var prenotazioniScadute = db.Prenotazionis.Where(p => p.Checkout < DateTime.Now).ToList();
        foreach (var prescad in prenotazioniScadute)
        {
            bookingIds.Remove(prescad.Codopz);
        }
        
        Console.WriteLine($"Prenotazioni da validare: {bookingIds.Count}.");
        
        foreach (var bookingId in bookingIds)
        {
            Console.WriteLine($"Sto validando la prenotazione {bookingId}.");
            var prenclis = db.Prenclis.Where(p => p.Codopz == bookingId).Select(p => p.Idcliente).ToList();
            var anagrafiche = new List<Anagrafiche>();
            foreach (var prencli in prenclis)
            {
                var anagrafica = db.Anagrafiches.Where(a => a.Id == prencli).FirstOrDefault();
                anagrafiche.Add(anagrafica);
            }


            var validationArray = new List<bool>();
            foreach (var anag in anagrafiche)
            {
                if (anag == null)
                {
                    validationArray.Add(false);
                    continue;
                }

                if (anag.Capo == -1)
                {
                    if (anag.Stato == "Italia")
                    {
                        if (anag.Nome != null && anag.Cognome != null && anag.Sesso != null && anag.Cellulare != null &&
                            anag.Datanasc != null && anag.Nazione != null && anag.Luogonasc != null &&
                            anag.Stato != null && anag.Numdoc != null && anag.Comune != null &&
                            anag.Indirizzo != null)
                        {
                            validationArray.Add(true);
                        }
                        else
                        {
                            validationArray.Add(false);
                        }
                    }
                    else
                    {
                        if (anag.Nome != null && anag.Cognome != null && anag.Sesso != null && anag.Cellulare != null &&
                            anag.Datanasc != null && anag.Nazione != null && anag.Luogonasc != null &&
                            anag.Stato != null && anag.Numdoc != null)
                        {
                            validationArray.Add(true);
                        }
                        else
                        {
                            validationArray.Add(false);
                        }
                    }
                }
                else
                {
                    if (anag.Stato == "Italia")
                    {
                        if (anag.Nome != null && anag.Cognome != null && anag.Sesso != null && anag.Datanasc != null &&
                            anag.Nazione != null && anag.Luogonasc != null && anag.Stato != null &&
                            anag.Comune != null)
                        {
                            validationArray.Add(true);
                        }
                        else
                        {
                            validationArray.Add(false);
                        }
                    }
                    else
                    {
                        if (anag.Nome != null && anag.Cognome != null && anag.Sesso != null && anag.Datanasc != null &&
                            anag.Nazione != null && anag.Luogonasc != null && anag.Stato != null)
                        {
                            validationArray.Add(true);
                        }
                        else
                        {
                            validationArray.Add(false);
                        }
                    }
                }
            }

            if (validationArray.Contains(false))
            {
                Console.WriteLine($"Non tutte le anagrafiche del booking {bookingId} sono complete.");
            }
            else
            {
                var prenclisToUpdate = db.Prenclis.Where(p => p.Codopz == bookingId).ToList();
                foreach (var prencli in prenclisToUpdate)
                {
                    prencli.Modificato = -1;
                }

                foreach (var anag in anagrafiche)
                {
                    anag.Modificato = -1;
                }

                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Errore durante il salvataggio delle modifiche su database.");
                }


                Console.WriteLine($"Prenotazione {bookingId} validata.");
            }

        }
        
        return Task.FromResult(true);
    }
}

