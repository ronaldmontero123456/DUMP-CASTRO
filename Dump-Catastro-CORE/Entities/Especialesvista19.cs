using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Especialesvista19
{
    public int? Id { get; set; }

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

    public string? Nombre { get; set; }

    public string? Codigoespecial { get; set; }

    public float? Valor { get; set; }

    public string? Materialcimientos { get; set; }

    public float? Valorcimientos { get; set; }

    public string? Materialestructura { get; set; }

    public float? Valorestructura { get; set; }

    public string? Materialmuros { get; set; }

    public float? Valormuros { get; set; }

    public string? Materialmurosext { get; set; }

    public float? Valormurosext { get; set; }

    public string? Materialmurosint { get; set; }

    public float? Valormurosint { get; set; }

    public string? Materialcubiertas { get; set; }

    public float? Valorcubiertas { get; set; }

    public string? Materialpisos { get; set; }

    public float? Valorpisos { get; set; }

    public string? Materialcarpinteria { get; set; }

    public float? Valorcarpinteria { get; set; }
}
