using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class Zonificacion
{
    public int Id { get; set; }

    public string? Clase { get; set; }

    public short? Subclase { get; set; }

    public double? ValorComercial { get; set; }

    public double? ValorCatastral { get; set; }

    public MultiPolygon? Geom { get; set; }
}
