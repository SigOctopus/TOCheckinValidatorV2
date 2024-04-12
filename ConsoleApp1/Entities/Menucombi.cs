using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Menucombi
{
    public string CodCombi { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string CodDescr { get; set; } = null!;

    public string Codstr { get; set; } = null!;

    public int Pgs { get; set; }

    public int? Modificato { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
