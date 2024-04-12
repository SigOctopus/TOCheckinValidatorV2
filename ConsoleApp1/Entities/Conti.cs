using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Conti
{
    public string Idrichiesta { get; set; } = null!;

    public int Idconto { get; set; }

    public DateOnly Data { get; set; }

    public string? Causale { get; set; }

    public decimal? Quanto { get; set; }
}
