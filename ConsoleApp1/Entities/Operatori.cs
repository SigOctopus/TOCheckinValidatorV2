using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Operatori
{
    public int Op { get; set; }

    public string Pro { get; set; } = null!;

    public string Codstr { get; set; } = null!;

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
