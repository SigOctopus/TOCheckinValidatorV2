using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Tavoli
{
    public int Tavolo { get; set; }

    public string CodStru { get; set; } = null!;

    public int Collegato { get; set; }

    public int? Modificato { get; set; }

    public string Codstr { get; set; } = null!;

    public int Pgs { get; set; }

    public string? Nomeesteso { get; set; }

    public int? CodCli { get; set; }

    public string? CodTess { get; set; }

    public string? Nominativo { get; set; }

    public string? Stato { get; set; }

    public int? Priprossimo { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
