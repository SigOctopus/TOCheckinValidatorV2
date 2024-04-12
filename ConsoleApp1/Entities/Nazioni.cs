using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Nazioni
{
    public string Nazione { get; set; } = null!;

    public string? Codice { get; set; }

    public string? Lingua { get; set; }

    public string? Codiceps { get; set; }

    public string? Cf { get; set; }

    public string? NomeIstat { get; set; }

    public string? GrpIstat { get; set; }

    public short? OrdIstat { get; set; }

    public string? Iso3166 { get; set; }

    public string? Uic { get; set; }
}
