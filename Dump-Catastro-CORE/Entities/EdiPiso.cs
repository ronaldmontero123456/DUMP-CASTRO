using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class EdiPiso
{
    public int Id { get; set; }

    public string? Material { get; set; }

    public float? Valor { get; set; }
}
