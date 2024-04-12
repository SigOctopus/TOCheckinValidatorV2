using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Prodottiordini
{
    public string IdOrdine { get; set; } = null!;

    public string IdProdotto { get; set; } = null!;

    public string? TipoProdotto { get; set; }

    public string? NoteAggiuntive { get; set; }
}
