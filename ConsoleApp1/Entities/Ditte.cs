using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Ditte
{
    public string Strcodice { get; set; } = null!;

    public int Codditta { get; set; }

    public string? Ragsoc { get; set; }

    public string? Email { get; set; }

    public int? Allotment { get; set; }

    public virtual Strutture StrcodiceNavigation { get; set; } = null!;
}
