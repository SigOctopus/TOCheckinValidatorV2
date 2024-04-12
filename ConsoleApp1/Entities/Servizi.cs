using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Servizi
{
    public string Codstr { get; set; } = null!;

    public int Numpiazz { get; set; }

    public int Idutente { get; set; }

    public int Codserv { get; set; }

    public string? Servizio { get; set; }

    public string? Tipo { get; set; }

    public virtual Termoreg Termoreg { get; set; } = null!;

    public virtual Utenti Utenti { get; set; } = null!;
}
