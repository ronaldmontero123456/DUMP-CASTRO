using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class VistaCatastro
{
    public string? Properties { get; set; }

    public string? Type { get; set; }

    public MultiPolygon? Geometry { get; set; }
}
