using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Dump_Catastro_CORE.Entities;

public partial class Terrenosvista19
{
    public long? Id { get; set; }

    public string? Codigo { get; set; }

    public string? Direccion { get; set; }

    public float? Superficie { get; set; }

    public string? Barrio { get; set; }

    public int? Via { get; set; }

    public bool? Agua { get; set; }

    public bool? Alcantarillado { get; set; }

    public bool? Energia { get; set; }

    public bool? Telefono { get; set; }

    public bool? Transporte { get; set; }

    public bool? Internet { get; set; }

    public int? Titular { get; set; }

    public int? Topografia { get; set; }

    public int? Forma { get; set; }

    public int? Ubicacion { get; set; }

    public double? Frente { get; set; }

    public double? Fondo { get; set; }

    public double? Suptest { get; set; }

    public string? Manzano { get; set; }

    public string? Predio { get; set; }

    public string? Subpredio { get; set; }

    public string? Norte { get; set; }

    public string? Sur { get; set; }

    public string? Este { get; set; }

    public string? Oeste { get; set; }

    public string? Base { get; set; }

    public int? Zona { get; set; }

    public int? MaterialVia { get; set; }

    public MultiPolygon? Geom { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int? Documento { get; set; }

    public int? TipoDoc { get; set; }

    public int? Caracter { get; set; }

    public int? DocumentoProp { get; set; }

    public int? Adquisicion { get; set; }

    public string? Nombrecaracter { get; set; }

    public string? Codigocaracter { get; set; }

    public string? Nombreadquisicion { get; set; }

    public string? Codigoadquisicion { get; set; }

    public string? Codigodocumento { get; set; }

    public string? Tipodocumento { get; set; }

    public string? Codigodocumnetopropiedad { get; set; }

    public string? Documentopropiedad { get; set; }

    public string? Tipovia { get; set; }

    public float? Valorvia { get; set; }

    public string? Nombretopo { get; set; }

    public string? Descrtopo { get; set; }

    public float? Valortopo { get; set; }

    public string? Nombreforma { get; set; }

    public string? Codigoforma { get; set; }

    public float? Valorforma { get; set; }

    public string? Nombreubicacion { get; set; }

    public string? Codigoubicacion { get; set; }

    public float? Valorubicacion { get; set; }

    public double? Valorcatastralzona { get; set; }

    public int? Idzona { get; set; }

    public double? Valorcomercialzona { get; set; }

    public string? Materialvia1 { get; set; }

    public float? Valormaterialvial { get; set; }

    public int? OtUsuario { get; set; }

    public string? NTest { get; set; }

    public DateOnly? FechaTest { get; set; }

    public string? FolioDdrr { get; set; }

    public double? Perimetro { get; set; }
}
