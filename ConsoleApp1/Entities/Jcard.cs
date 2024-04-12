using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Jcard
{
    public string Name { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public int ExpYear { get; set; }

    public int ExpMonth { get; set; }

    public string Cvc { get; set; } = null!;

    public string AddressCountry { get; set; } = null!;
}
