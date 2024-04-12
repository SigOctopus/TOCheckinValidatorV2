using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Utenti
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Passw { get; set; } = null!;

    public string Codstr { get; set; } = null!;

    public int Ruoloutente { get; set; }

    public string Tipoutente { get; set; } = null!;

    public string? Gruppo { get; set; }

    public int? Presente { get; set; }

    public int? Modificato { get; set; }

    public string? Email { get; set; }

    public string? PasswordCriptata { get; set; }

    public virtual ICollection<Attivazioni> Attivazionis { get; set; } = new List<Attivazioni>();

    public virtual ICollection<Servizi> Servizis { get; set; } = new List<Servizi>();
}
