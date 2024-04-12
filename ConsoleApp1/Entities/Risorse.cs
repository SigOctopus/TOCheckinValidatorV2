using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Risorse
{
    public string Codice { get; set; } = null!;

    public string Strcodice { get; set; } = null!;

    public double? Topx { get; set; }

    public double? Leftx { get; set; }

    public double? Height { get; set; }

    public double? Width { get; set; }

    public int Red { get; set; }

    public int Green { get; set; }

    public int Blu { get; set; }

    public byte[]? Img { get; set; }

    public DateTime? Ultmodifica { get; set; }

    public string? Nomeicona { get; set; }

    public string Tipologia { get; set; } = null!;

    public string? Nomeesteso { get; set; }

    public string? Codopzione { get; set; }

    public string? Descrizione { get; set; }

    public decimal? Prezzo { get; set; }

    public string? Tiposervizio { get; set; }

    public int? Attivo { get; set; }

    public int? Ordine { get; set; }

    public int Qta { get; set; }

    public int Pgs { get; set; }

    public int? Linkmappa { get; set; }

    public double? Topcl { get; set; }

    public double? Leftcl { get; set; }

    public int? Inmappa { get; set; }

    public string? Prenotrisors { get; set; }

    public int? TopTo { get; set; }

    public int? LeftTo { get; set; }

    public string? MappaTo { get; set; }

    public short? Grigio { get; set; }
}
