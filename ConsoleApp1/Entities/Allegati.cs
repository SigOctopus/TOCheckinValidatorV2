using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Allegati
{
    public string Idanagrafica { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Nomefile { get; set; } = null!;

    public byte[]? Blob { get; set; }

    public string Codopz { get; set; } = null!;

    public int? Modificato { get; set; }

    public DateTime? Download { get; set; }

    public virtual Anagrafiche IdanagraficaNavigation { get; set; } = null!;
}
