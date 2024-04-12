using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Comuni
{
    public string Comune { get; set; } = null!;

    public string? Provincia { get; set; }

    public string? Cap { get; set; }

    public string? Cf { get; set; }

    public int? Codice { get; set; }

    public string? ProvIstat { get; set; }

    public short? CapCitta { get; set; }
}
