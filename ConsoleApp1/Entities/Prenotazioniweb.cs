using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Prenotazioniweb
{
    public string Id { get; set; } = null!;

    public string StrCodice { get; set; } = null!;

    public string RisCodice { get; set; } = null!;

    public DateOnly Da { get; set; }

    public DateOnly A { get; set; }

    public int? DaEliminare { get; set; }

    public DateTime? Scade { get; set; }

    public int? Opzione { get; set; }

    public int? Esportata { get; set; }

    public int? Eliminata { get; set; }

    public decimal Prezzo { get; set; }

    public string? Origine { get; set; }

    public string? Padre { get; set; }

    public int Adulti { get; set; }

    public int Bambini { get; set; }

    public string? Coupon { get; set; }

    public string? PagId { get; set; }

    public int? InMappa { get; set; }

    public short? Ragazzi { get; set; }

    public short? Lettini { get; set; }

    public short? Sdraio { get; set; }

    public short? Sedie { get; set; }

    public short? Nopaga { get; set; }

    public short? CodAllotm { get; set; }

    public string? Idanagrafica { get; set; }

    public string? Impegno { get; set; }
}
