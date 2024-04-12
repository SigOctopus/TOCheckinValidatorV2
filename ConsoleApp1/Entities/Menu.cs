using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Menu
{
    public string Tipomenu { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int Priorita { get; set; }

    public string CodDescr { get; set; } = null!;

    public string Descriz { get; set; } = null!;

    public string Specifiche { get; set; } = null!;

    public double Prezzo { get; set; }

    public string Reparto { get; set; } = null!;

    public int GCritica { get; set; }

    public int Pgs { get; set; }

    public string Codstr { get; set; } = null!;

    public double PercMezza { get; set; }

    public int? Stampante { get; set; }

    public string? Combinato { get; set; }

    public int? Modificato { get; set; }

    public int? Rapidomenu { get; set; }

    public int? Mobile { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
