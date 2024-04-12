using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Ordini
{
    public string? IdUtente { get; set; }

    public string IdOrdine { get; set; } = null!;

    public double? Prezzo { get; set; }

    public string? NoteInterne { get; set; }

    public string? NoteCliente { get; set; }

    public DateTime? DataAcquisto { get; set; }

    public string? Stato { get; set; }

    public string Struttura { get; set; } = null!;

    public string? Tipologia { get; set; }

    public string? IdPagamento { get; set; }

    public string? SistemaPagamento { get; set; }

    public string? MetodoFatturazione { get; set; }
}
