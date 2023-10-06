using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class Construcciones19
{
    public int Id { get; set; }

    public int? Cod { get; set; }

    public string? Codigo { get; set; }

    public int? Plantas { get; set; }

    public string? Anyo { get; set; }

    public int? Conservacion { get; set; }

    public int? Uso { get; set; }

    public float? Superficie { get; set; }

    public int? Dormitorios { get; set; }

    public int? Banyos { get; set; }

    public int? Revestimiento { get; set; }

    public bool? Ascensores { get; set; }

    public bool? Calefaccion { get; set; }

    public bool? Aire { get; set; }

    public bool? Escalera { get; set; }

    public bool? Tanque { get; set; }

    public bool? Lavanderia { get; set; }

    public bool? Servicio { get; set; }

    public bool? Sanitarios { get; set; }

    public int? Tipo { get; set; }

    public MultiPolygon? Geom { get; set; }
}
