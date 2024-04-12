using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Termattivi
{
    public string Deviceid { get; set; } = null!;

    public string Codstr { get; set; } = null!;

    public string Idtel { get; set; } = null!;

    public DateTime Ultrichiesta { get; set; }

    public int Vieta { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
