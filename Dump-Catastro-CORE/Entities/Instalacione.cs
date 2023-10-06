using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Instalacione
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public float? Valor { get; set; }
}
