using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class Terrenos20
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Direccion { get; set; }

    public float? Superficie { get; set; }

    public string? Barrio { get; set; }

    public int? Via { get; set; }

    public bool? Agua { get; set; }

    public bool? Alcantarillado { get; set; }

    public bool? Energia { get; set; }

    public bool? Telefono { get; set; }

    public bool? Transporte { get; set; }

    public bool? Internet { get; set; }

    public int? Titular { get; set; }

    public int? Topografia { get; set; }

    public int? Forma { get; set; }

    public int? Ubicacion { get; set; }

    public string? Frente { get; set; }

    public string? Fondo { get; set; }

    public string? Suptest { get; set; }

    public string? Manzano { get; set; }

    public string? Predio { get; set; }

    public string? Subpredio { get; set; }

    public string? Norte { get; set; }

    public string? Sur { get; set; }

    public string? Este { get; set; }

    public string? Oeste { get; set; }

    public string? Base { get; set; }

    public MultiPolygon? Geom { get; set; }
}
