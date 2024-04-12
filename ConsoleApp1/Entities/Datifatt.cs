using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Datifatt
{
    public string Ragsoc { get; set; } = null!;

    public string Indirizzo { get; set; } = null!;

    public string Codstr { get; set; } = null!;

    public string? Cf { get; set; }

    public string Pi { get; set; } = null!;

    public string? Email { get; set; }

    public string? Notex { get; set; }

    public string Codopz { get; set; } = null!;

    public string Comune { get; set; } = null!;

    public string Provincia { get; set; } = null!;

    public string Nazione { get; set; } = null!;

    public string Cap { get; set; } = null!;

    public int? Modificato { get; set; }

    public string? Pec { get; set; }

    public string? Sdi { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
