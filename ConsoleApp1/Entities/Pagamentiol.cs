using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Pagamentiol
{
    public string Strcod { get; set; } = null!;

    public int Pgs { get; set; }

    public string? Esito { get; set; }

    public string? Jcard { get; set; }

    public string? Jaddress { get; set; }

    public string? Jcustom { get; set; }

    public string? Joptions { get; set; }

    public string? ReceiptUrl { get; set; }

    public DateTime? Data { get; set; }
}
