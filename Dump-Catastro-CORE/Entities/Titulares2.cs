using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Titulares2
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int Documento { get; set; }

    public int? TipoDoc { get; set; }

    public int? Caracter { get; set; }

    public int? DocumentoProp { get; set; }

    public int? Adquisicion { get; set; }
}
