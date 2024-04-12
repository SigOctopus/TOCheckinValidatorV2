using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Comande
{
    public DateTime Data { get; set; }

    public string Ora { get; set; } = null!;

    public int Tavolo { get; set; }

    public string CodStru { get; set; } = null!;

    public int? CodCli { get; set; }

    public string? CodTess { get; set; }

    public string? Variante { get; set; }

    public string? VariaCod { get; set; }

    public string? Tipo { get; set; }

    public int Qta { get; set; }

    public string? CodArt { get; set; }

    public string? Descriz { get; set; }

    public decimal? Prezzo { get; set; }

    public int Finito { get; set; }

    public int Cancellato { get; set; }

    public int Collegato { get; set; }

    public int Priorita { get; set; }

    public string? Idpalm { get; set; }

    public int Modificato { get; set; }

    public string Menu { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string Codstr { get; set; } = null!;

    public int? Stampante { get; set; }

    public int? Stampato { get; set; }

    public int? Preparato { get; set; }

    public int? Numrig { get; set; }

    public string? Origine { get; set; }

    public string? NoteCons { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
