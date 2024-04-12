using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Joption
{
    public int Amount { get; set; }

    public string Importo { get; set; } = null!;

    public string ReceptEmail { get; set; } = null!;

    public string Description { get; set; } = null!;
}
