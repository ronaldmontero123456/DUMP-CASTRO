using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Imagene
{
    public int Id { get; set; }

    public byte[]? Imagen { get; set; }

    public string? Terreno19 { get; set; }

    public int? Construccion19 { get; set; }

    public string? Terreno20 { get; set; }

    public int? Construccion20 { get; set; }
}
