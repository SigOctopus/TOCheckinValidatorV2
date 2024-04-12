using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Grtipologie
{
    public string Gruppo { get; set; } = null!;

    public string Strcodice { get; set; } = null!;

    public byte[]? Img { get; set; }

    public byte[]? Imgred { get; set; }

    public byte[]? Imggray { get; set; }

    public string? Estensione { get; set; }

    public byte[]? Imgorange { get; set; }
}
