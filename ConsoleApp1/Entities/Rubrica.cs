using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Rubrica
{
    public int Idrubrica { get; set; }

    public string Cognome { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Indirizzo { get; set; }

    public int? Cap { get; set; }

    public string? Comune { get; set; }

    public string? Sigla { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
