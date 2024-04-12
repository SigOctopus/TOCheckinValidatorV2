using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Prezziba
{
    public string Strcodice { get; set; } = null!;

    public string Tipotarif { get; set; } = null!;

    public DateOnly Dal { get; set; }

    public DateOnly Al { get; set; }

    public int Numg { get; set; }

    public string Nomestag { get; set; } = null!;

    public string Tipocab { get; set; } = null!;

    public string Tipoombr { get; set; } = null!;

    public int Sdraio { get; set; }

    public int Lettini { get; set; }

    public int? Ammessa { get; set; }

    public decimal Prezzo { get; set; }

    public int Incluse { get; set; }

    public decimal? Altrepers { get; set; }

    public decimal? RidBamb { get; set; }

    public decimal? Sdraioagg { get; set; }

    public decimal? Lettiniagg { get; set; }

    public decimal? SedieAgg { get; set; }

    public virtual Strutture StrcodiceNavigation { get; set; } = null!;
}
