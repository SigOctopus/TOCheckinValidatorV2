using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Articoli
{
    public string CodArt { get; set; } = null!;

    public string Descriz { get; set; } = null!;

    public decimal PrCon { get; set; }

    public decimal PrSenza { get; set; }

    public decimal PrTanto { get; set; }

    public decimal PrPoco { get; set; }

    public string Codstr { get; set; } = null!;

    public int Pgs { get; set; }

    public int? Modificato { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
