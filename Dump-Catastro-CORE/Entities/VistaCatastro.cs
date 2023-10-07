using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class VistaCatastro
{
    public string? Properties { get; set; }

    public string? Type { get; set; }

    public MultiPolygon? Geometry { get; set; }
    [JsonIgnore]
    public string? Codigo { get; set; }
    [JsonIgnore]
    public string? Nombre { get; set; }
    [JsonIgnore]
    public int? Documento { get; set; }
}
