using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Mappe
{
    public int Pgs { get; set; }

    public string Codice { get; set; } = null!;

    public string Descrizmappa { get; set; } = null!;

    public byte[]? Blob { get; set; }

    public string? Nomefile { get; set; }

    public string? Estensione { get; set; }

    public string? Tipo { get; set; }

    public string? RiduciSuMobile { get; set; }

    public int Wmappa { get; set; }

    public int Hmappa { get; set; }

    public short? Attiva { get; set; }

    public string? TipoSt { get; set; }

    public string? TestoHtml { get; set; }

    public virtual Strutture CodiceNavigation { get; set; } = null!;
}
