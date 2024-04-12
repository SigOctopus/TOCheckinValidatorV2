using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Restlog
{
    public DateTime Dataora { get; set; }

    public string Richiesta { get; set; } = null!;

    public string Params { get; set; } = null!;

    public int Id { get; set; }
}
