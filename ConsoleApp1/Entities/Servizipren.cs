using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Servizipren
{
    public string Strcodice { get; set; } = null!;

    public string Tipomenu { get; set; } = null!;

    public string CodDescr { get; set; } = null!;

    public string Idpren { get; set; } = null!;

    public int? Qta { get; set; }

    public virtual MenuServ MenuServ { get; set; } = null!;
}
