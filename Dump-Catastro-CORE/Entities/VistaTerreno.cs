using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class VistaTerreno
{
    public int? Id { get; set; }

    public string? Codigo { get; set; }

    public bool? Agua { get; set; }

    public bool? Alcantarillado { get; set; }

    public string? Barrio { get; set; }

    public string? Base { get; set; }

    public string? Direccion { get; set; }

    public bool? Energia { get; set; }

    public string? Este { get; set; }

    public double? Fondo { get; set; }

    public double? Frente { get; set; }

    public bool? Internet { get; set; }

    public string? Manzano { get; set; }

    public string? Norte { get; set; }

    public string? Oeste { get; set; }

    public string? Predio { get; set; }

    public string? Subpredio { get; set; }

    public float? Superficie { get; set; }

    public double? Suptest { get; set; }

    public string? Sur { get; set; }

    public bool? Telefono { get; set; }

    public bool? Transporte { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int? Documento { get; set; }

    public string? Adquisicion { get; set; }

    public string? Codigoadquisicion { get; set; }

    public string? Forma { get; set; }

    public float? Valor { get; set; }

    public string? Codigoforma { get; set; }

    public string? Material { get; set; }

    public string? Tipo { get; set; }

    public float? Valortipovia { get; set; }

    public MultiPolygon? Geometry { get; set; }
}
    