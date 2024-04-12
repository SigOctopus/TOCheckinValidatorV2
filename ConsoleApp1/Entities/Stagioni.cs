using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Stagioni
{
    public string Prodotto { get; set; } = null!;

    public string Nomelist { get; set; } = null!;

    public string Nomestag { get; set; } = null!;

    public DateOnly Dal { get; set; }

    public DateOnly Al { get; set; }

    public int Ordine { get; set; }

    public string Codice { get; set; } = null!;

    public int Giorno { get; set; }
}
