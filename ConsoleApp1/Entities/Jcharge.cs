using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Jcharge
{
    public string Amountjcharg { get; set; } = null!;

    public string Balatraidjch { get; set; } = null!;

    public string Capturjcharg { get; set; } = null!;

    public string Descrijcharg { get; set; } = null!;

    public string Paidjcharge { get; set; } = null!;

    public string Statusjcharg { get; set; } = null!;

    public string Failcodejcha { get; set; } = null!;

    public string Failmessjcha { get; set; } = null!;

    public DateTime Datajcharge { get; set; }

    public int Pgs { get; set; }

    public string Codice { get; set; } = null!;

    public virtual Strutture CodiceNavigation { get; set; } = null!;
}
