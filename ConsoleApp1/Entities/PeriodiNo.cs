using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class PeriodiNo
{
    public int Idperiodo { get; set; }

    public string Codice { get; set; } = null!;

    public DateOnly Dal { get; set; }

    public DateOnly Al { get; set; }

    public virtual Strutture CodiceNavigation { get; set; } = null!;
}
