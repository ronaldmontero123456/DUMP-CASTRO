using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class TipoDocumento
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string? Codigo { get; set; }
}
