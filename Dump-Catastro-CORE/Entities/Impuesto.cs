using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Impuesto
{
    public int Id { get; set; }

    public string? Anyo { get; set; }

    public string? Terrenos19 { get; set; }

    public string? Terrenos20 { get; set; }

    public bool? Pagado { get; set; }
}
