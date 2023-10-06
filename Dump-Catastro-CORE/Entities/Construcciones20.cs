using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class Construcciones20
{
    public int Id { get; set; }

    public int? Cod { get; set; }

    public string? Codigo { get; set; }

    public int? Plantas { get; set; }

    public int? Anyo { get; set; }

    public int? Conservacion { get; set; }

    public int? Uso { get; set; }

    public float? Superficie { get; set; }

    public int? Dormitorios { get; set; }

    public int? Banyos { get; set; }

    public int? Revestimiento { get; set; }

    public MultiPolygon? Geom { get; set; }
}
