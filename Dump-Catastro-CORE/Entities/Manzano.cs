using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class Manzano
{
    public int Id { get; set; }

    public string Manzana { get; set; } = null!;

    public double? Superficie { get; set; }

    public double? Perimetro { get; set; }

    public string? Status { get; set; }

    public MultiPolygon? Geom { get; set; }
}
