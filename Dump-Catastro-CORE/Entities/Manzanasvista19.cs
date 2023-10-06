using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class Manzanasvista19
{
    public string? Manzano { get; set; }

    public Geometry? StMulti { get; set; }
}
