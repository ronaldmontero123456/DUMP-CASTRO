using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Conservacion
{
    public int Id { get; set; }

    public string? Estado { get; set; }

    public float? Valor { get; set; }
}
