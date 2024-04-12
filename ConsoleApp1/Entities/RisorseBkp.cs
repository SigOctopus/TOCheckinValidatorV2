using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class RisorseBkp
{
    public string Codice { get; set; } = null!;

    public string Strcodice { get; set; } = null!;

    public double? Topx { get; set; }

    public double? Leftx { get; set; }

    public string Tipologia { get; set; } = null!;

    public string? Nomeesteso { get; set; }

    public string? Codopzione { get; set; }

    public string? Descrizione { get; set; }

    public decimal? Prezzo { get; set; }

    public string? Tiposervizio { get; set; }

    public int? Attivo { get; set; }

    public int? Ordine { get; set; }

    public int Qta { get; set; }

    public int Pgs { get; set; }

    public int? Linkmappa { get; set; }
}
