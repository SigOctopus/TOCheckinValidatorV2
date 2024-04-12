using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Prenotazioni
{
    public string Id { get; set; } = null!;

    public string Codstr { get; set; } = null!;

    public string Codopz { get; set; } = null!;

    public DateTime Checkin { get; set; }

    public DateTime Checkout { get; set; }

    public string Cognome { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Tipopren { get; set; } = null!;

    public int Persone { get; set; }

    public int? Bambini { get; set; }

    public int? Ridottia { get; set; }

    public int? Ridottib { get; set; }

    public int? Ridottic { get; set; }

    public string? Altririd { get; set; }

    public DateTime? Datamodifica { get; set; }

    public string? Guidx { get; set; }

    public string Lingua { get; set; } = null!;

    public string? Targauto { get; set; }

    public int? Modificato { get; set; }

    public string? Idanagrafica { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;

    public virtual Anagrafiche? IdanagraficaNavigation { get; set; }
}
