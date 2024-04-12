using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Pagamenti
{
    public string Strcodice { get; set; } = null!;

    public string Codblocco { get; set; } = null!;

    public DateOnly Data { get; set; }

    public decimal Prezzo { get; set; }

    public string? Tipopag { get; set; }

    public short? Acconto { get; set; }

    public string? Idpagamento { get; set; }

    public decimal? Imponibile { get; set; }

    public decimal? Iva { get; set; }

    public int? Nfatt { get; set; }

    public string? Descrizione { get; set; }
}
