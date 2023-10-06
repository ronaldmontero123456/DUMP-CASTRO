using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Especiale
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Codigo { get; set; }

    public float? Valor { get; set; }
}
