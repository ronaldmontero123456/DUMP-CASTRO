using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Titular
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int Documento { get; set; }

    public int? TipoDoc { get; set; }

    public int? Caracter { get; set; }

    public int? DocumentoProp { get; set; }

    public int? Adquisicion { get; set; }

    public virtual Adquisicion? AdquisicionNavigation { get; set; }

    public virtual CaracterTitular? CaracterNavigation { get; set; }

    public virtual DocumentoPropiedad? DocumentoPropNavigation { get; set; }

    public virtual TipoDocumento? TipoDocNavigation { get; set; }
}
