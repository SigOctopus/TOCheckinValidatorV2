using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Orariapertura
{
    public int Idorario { get; set; }

    public string Codice { get; set; } = null!;

    public TimeOnly Dalleorario { get; set; }

    public TimeOnly Alleorario { get; set; }

    public DateOnly Dalorario { get; set; }

    public DateOnly Alorario { get; set; }

    public string? Giorniorario { get; set; }

    public int? Per { get; set; }

    public virtual Strutture CodiceNavigation { get; set; } = null!;
}
