using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class TipologiaPar
{
    public int Id { get; set; }

    public string StrCodice { get; set; } = null!;

    public string Tipologia { get; set; } = null!;

    public int Maxlettini { get; set; }

    public int Maxsdraio { get; set; }

    public int? Minlettini { get; set; }

    public int? Minsdraio { get; set; }

    public short? MinSedie { get; set; }

    public short? MaxSedie { get; set; }

    public short? MinAccessori { get; set; }

    public short? MaxAccessori { get; set; }
}
