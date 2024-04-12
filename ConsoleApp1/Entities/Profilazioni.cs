using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Profilazioni
{
    public int Id { get; set; }

    public int CodCli { get; set; }

    public string Profilo { get; set; } = null!;

    public DateTime? DataMod { get; set; }

    public string CodStr { get; set; } = null!;
}
