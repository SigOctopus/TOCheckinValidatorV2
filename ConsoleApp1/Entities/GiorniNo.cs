using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class GiorniNo
{
    public int Idgn { get; set; }

    public string Codice { get; set; } = null!;

    public string Giorni { get; set; } = null!;

    public DateOnly? Dal { get; set; }

    public DateOnly? Al { get; set; }

    public virtual Strutture CodiceNavigation { get; set; } = null!;
}
