using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Coupon
{
    public string Strcodice { get; set; } = null!;

    public string Nomelist { get; set; } = null!;

    public string Nomestag { get; set; } = null!;

    public decimal? ScPerc { get; set; }

    public decimal? ScCorpo { get; set; }

    public decimal? MinSpesa { get; set; }

    public decimal? MaxSpesa { get; set; }

    public int? Qta { get; set; }

    public virtual Strutture StrcodiceNavigation { get; set; } = null!;
}
