using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class VistaConstruccione
{
    public int? Id { get; set; }

    public string? Codigo { get; set; }

    public bool? Aire { get; set; }

    public string? Anyo { get; set; }

    public bool? Ascensores { get; set; }

    public bool? Calefaccion { get; set; }

    public int? Cod { get; set; }

    public int? Dormitorios { get; set; }

    public bool? Escalera { get; set; }

    public MultiPolygon? Geometry { get; set; }

    public bool? Lavanderia { get; set; }

    public int? Plantas { get; set; }

    public bool? Sanitarios { get; set; }

    public bool? Servicio { get; set; }

    public bool? Tanque { get; set; }

    public int? Idconservacion { get; set; }

    public string? Estadoconservacion { get; set; }

    public float? Conservacion { get; set; }

    public int? Idrevestimiento { get; set; }

    public string? Revestimiento { get; set; }
}
