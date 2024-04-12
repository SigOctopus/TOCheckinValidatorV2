using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class MenuServ
{
    public string Strcodice { get; set; } = null!;

    public string Tipomenu { get; set; } = null!;

    public string CodDescr { get; set; } = null!;

    public string? Tipo { get; set; }

    public string? Descriz { get; set; }

    public decimal? Prezzo { get; set; }

    public decimal? Iva { get; set; }

    public string? Reparto { get; set; }

    public string? NonDisp { get; set; }

    public int? Eliminato { get; set; }

    public int? Xgiorno { get; set; }

    public int? Xpersona { get; set; }

    public string? Specifiche { get; set; }

    public short? Richqta { get; set; }

    public virtual ICollection<Servizipren> Serviziprens { get; set; } = new List<Servizipren>();

    public virtual Strutture StrcodiceNavigation { get; set; } = null!;
}
