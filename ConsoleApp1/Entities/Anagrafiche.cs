using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Anagrafiche
{
    public string Id { get; set; } = null!;

    public string CodStr { get; set; } = null!;

    public string? Guidx { get; set; }

    public int? Prenotante { get; set; }

    public int? Capo { get; set; }

    public string Cognome { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Sesso { get; set; }

    public int? Itanasc { get; set; }

    public DateTime? Datanasc { get; set; }

    public string? Indirizzo { get; set; }

    public string? Email { get; set; }

    public string? Cellulare { get; set; }

    public string? Numdoc { get; set; }

    public DateTime? Datarilascio { get; set; }

    public DateTime Datains { get; set; }

    public string? Notex { get; set; }

    public string? Provincia { get; set; }

    public string? Comune { get; set; }

    public string? Nazione { get; set; }

    public string? Cap { get; set; }

    public int L675spot { get; set; }

    public int L675smg { get; set; }

    public int L675part { get; set; }

    public string? TipoDoc { get; set; }

    public string? Luogonasc { get; set; }

    public int? Modificato { get; set; }

    public string? Gruppo { get; set; }

    public int? Presente { get; set; }

    public int L675firma { get; set; }

    public int Codcli { get; set; }

    public int? Privacyvista { get; set; }

    public DateTime? Lastpren { get; set; }

    public string? Stato { get; set; }

    public string? Pi { get; set; }

    public DateTime? Dataprivacyvista { get; set; }

    public int L675read { get; set; }

    public int? Indip { get; set; }

    public string? Passwordx { get; set; }

    public int? EmailVerificata { get; set; }

    public string? PvNascita { get; set; }

    public int Push { get; set; }

    public string? StatoResidenza { get; set; }

    public string? Regione { get; set; }

    public string? FirebaseId { get; set; }

    public string? Cf { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public double? Fido { get; set; }

    public virtual ICollection<Allegati> Allegatis { get; set; } = new List<Allegati>();

    public virtual Strutture CodStrNavigation { get; set; } = null!;

    public virtual ICollection<Prenotazioni> Prenotazionis { get; set; } = new List<Prenotazioni>();
}
