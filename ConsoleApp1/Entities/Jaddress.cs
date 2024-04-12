using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Jaddress
{
    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Line1 { get; set; } = null!;

    public string Line2 { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string State { get; set; } = null!;
}
