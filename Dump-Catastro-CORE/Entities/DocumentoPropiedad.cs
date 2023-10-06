using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class DocumentoPropiedad
{
    public int Id { get; set; }

    public string? Documento { get; set; }

    public string? Codigo { get; set; }
}
