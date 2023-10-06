using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class Ejevia
{
    public int Id { get; set; }

    public int Manzana { get; set; }

    public string Nombre { get; set; } = null!;

    public LineString? Geom { get; set; }
}
