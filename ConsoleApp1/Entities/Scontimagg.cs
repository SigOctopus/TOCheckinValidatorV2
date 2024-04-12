using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Scontimagg
{
    public int Idscmagg { get; set; }

    public string Codice { get; set; } = null!;

    public DateOnly Dal { get; set; }

    public DateOnly Al { get; set; }

    public decimal? Scontomagg { get; set; }

    public string? Tipologia { get; set; }

    public int? Percento { get; set; }

    public int? Algiorno { get; set; }

    public string? Tipoblocco { get; set; }

    public virtual Strutture CodiceNavigation { get; set; } = null!;
}
