using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Semaforo
{
    public int Id { get; set; }

    public string StrCodice { get; set; } = null!;

    public string? IdPren { get; set; }
}
