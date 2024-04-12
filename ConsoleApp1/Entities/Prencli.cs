using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Prencli
{
    public string Codstr { get; set; } = null!;

    public string Codopz { get; set; } = null!;

    public int Codcli { get; set; }

    public string Idcliente { get; set; } = null!;

    public int? Modificato { get; set; }

    public int? Presente { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
