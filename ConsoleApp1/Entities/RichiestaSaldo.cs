using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class RichiestaSaldo
{
    public string Id { get; set; } = null!;

    public string StrCodice { get; set; } = null!;

    public string PrenId { get; set; } = null!;

    public int? Gestita { get; set; }

    public string? Cognome { get; set; }

    public string? Nome { get; set; }

    public int? Cap { get; set; }

    public string? Indirizzo { get; set; }

    public string? Cf { get; set; }

    public string? Citta { get; set; }

    public decimal? Saldo { get; set; }

    public string? Provincia { get; set; }

    public string? Motivo { get; set; }

    public int? Pagato { get; set; }

    public string? Email { get; set; }

    public string? Tipologia { get; set; }

    public virtual Strutture StrCodiceNavigation { get; set; } = null!;
}
