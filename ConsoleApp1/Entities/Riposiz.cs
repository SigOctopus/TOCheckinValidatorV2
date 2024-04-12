using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Riposiz
{
    public int Idrip { get; set; }

    public string Codice { get; set; } = null!;

    public int Tiporip { get; set; }

    public int Ordinerip { get; set; }

    public virtual Strutture CodiceNavigation { get; set; } = null!;
}
