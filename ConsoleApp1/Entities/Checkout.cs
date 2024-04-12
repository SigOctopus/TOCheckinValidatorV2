using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Checkout
{
    public string Id { get; set; } = null!;

    public string Codblocco { get; set; } = null!;

    public int Amount { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Modo { get; set; } = null!;

    public string? Pagato { get; set; }

    public int Codcli { get; set; }

    public string? Idanagrafica { get; set; }

    public DateTime? Data { get; set; }

    public string? MotivoPagamento { get; set; }
}
