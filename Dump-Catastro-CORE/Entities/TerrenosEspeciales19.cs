using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class TerrenosEspeciales19
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public int? IdEsp { get; set; }

    public int? Cimiento { get; set; }

    public int? Estructura { get; set; }

    public int? Muros { get; set; }

    public int? MurosExt { get; set; }

    public int? MurosInt { get; set; }

    public int? Cubierta { get; set; }

    public int? Pisos { get; set; }

    public int? Carpinteria { get; set; }

    public string? Anyo { get; set; }

    public int? Conservacion { get; set; }

    public string? Superficie { get; set; }
}
