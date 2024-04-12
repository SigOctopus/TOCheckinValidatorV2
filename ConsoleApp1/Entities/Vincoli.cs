using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Vincoli
{
    public string Codstr { get; set; } = null!;

    public string Tipologia { get; set; } = null!;

    public int Adulti { get; set; }

    public int Ragazzi { get; set; }

    public int Bambini { get; set; }

    public int? Lettini { get; set; }

    public int? Sdraio { get; set; }

    public int? Sedie { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
