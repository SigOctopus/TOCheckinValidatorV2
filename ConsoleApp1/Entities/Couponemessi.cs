using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Couponemessi
{
    public string Coupon { get; set; } = null!;

    public string Strcodice { get; set; } = null!;

    public string Nomelist { get; set; } = null!;

    public string Nomestag { get; set; } = null!;

    public int? Burned { get; set; }
}
