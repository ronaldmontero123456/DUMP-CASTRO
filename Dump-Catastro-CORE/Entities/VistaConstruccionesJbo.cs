using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class VistaConstruccionesJbo
{
    public string? Properties { get; set; }

    public string? Type { get; set; }

    public MultiPolygon? Geometry { get; set; }

    public string? Codigo { get; set; }
}
