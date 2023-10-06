using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class TipoConstruccion
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public float? Valor { get; set; }
}
