using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Tipologie
{
    public string Tipologia { get; set; } = null!;

    public int? Attivo { get; set; }

    public string Codstr { get; set; } = null!;

    public byte[]? Img { get; set; }

    public byte[]? Imgred { get; set; }

    public byte[]? Imggray { get; set; }

    public string? Codtipo { get; set; }

    public string? Estensione { get; set; }

    public int? Etaadulta { get; set; }

    public int? Maxadulti { get; set; }

    public double? Maxbambini { get; set; }

    public int? Maxlettini { get; set; }

    public int? Maxsdraio { get; set; }

    public short? Maxraga { get; set; }

    public short? Etaraga { get; set; }

    public short? Maxumani { get; set; }

    public int? Minlettini { get; set; }

    public int? Minsdraio { get; set; }

    public short? MinSedie { get; set; }

    public short? MaxSedie { get; set; }

    public short? MaxArticoli { get; set; }

    public short? MaxNoPaga { get; set; }

    public string? Etichadulti { get; set; }

    public string? EtichRaga { get; set; }

    public string? Etichbamb { get; set; }

    public string? Etichnopaga { get; set; }

    public string? Descrizione { get; set; }

    public virtual Strutture CodstrNavigation { get; set; } = null!;
}
