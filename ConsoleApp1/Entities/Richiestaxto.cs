using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Richiestaxto
{
    public int Id { get; set; }

    public string StrCodice { get; set; } = null!;

    public int? Gestita { get; set; }

    public string? Email { get; set; }

    public string? Tipologia { get; set; }

    public short? Rispobool { get; set; }

    public string? Risorse { get; set; }

    public virtual Strutture StrCodiceNavigation { get; set; } = null!;
}
