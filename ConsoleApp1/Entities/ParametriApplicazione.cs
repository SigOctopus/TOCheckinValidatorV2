using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class ParametriApplicazione
{
    public string Serie { get; set; } = null!;

    public int Codice { get; set; }

    public string Codstr { get; set; } = null!;

    public string CgpDescrizione { get; set; } = null!;

    public string TipoDato { get; set; } = null!;

    public string Valore { get; set; } = null!;

    public string? FlagTipo { get; set; }

    public int Sequenza { get; set; }

    public string? Descestesa { get; set; }
}
