using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Termoreg
{
    public string Codstr { get; set; } = null!;

    public int NumPiazz { get; set; }

    public string Tipo { get; set; } = null!;

    public string? ZonaClima1 { get; set; }

    public string? ZonaClima2 { get; set; }

    public string? ZonaClima3 { get; set; }

    public int? Velo1 { get; set; }

    public int? Velo2 { get; set; }

    public int? Velo3 { get; set; }

    public int? Temp1 { get; set; }

    public int? Temp2 { get; set; }

    public int? Temp3 { get; set; }

    public int? TempCli1 { get; set; }

    public int? TempCli2 { get; set; }

    public int? TempCli3 { get; set; }

    public int? TempCli4 { get; set; }

    public int? Temp4 { get; set; }

    public DateTime? AttivaDal { get; set; }

    public DateTime? AttivaFinoAl { get; set; }

    public int? LuciOnOff { get; set; }

    public int? FinestreBloc { get; set; }

    public int? PortaChiusa { get; set; }

    public int? Modificato { get; set; }

    public string? ZonaClima4 { get; set; }

    public int? Velo4 { get; set; }

    public virtual ICollection<Attivazioni> Attivazionis { get; set; } = new List<Attivazioni>();

    public virtual Strutture CodstrNavigation { get; set; } = null!;

    public virtual ICollection<Servizi> Servizis { get; set; } = new List<Servizi>();
}
