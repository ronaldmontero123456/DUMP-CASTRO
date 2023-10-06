using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Zona
{
    public int Id { get; set; }

    public double? ValorComercial { get; set; }

    public float? ValorCatastral { get; set; }

    public string? Etiqueta { get; set; }

    public virtual ICollection<Terrenos19> Terrenos19s { get; set; } = new List<Terrenos19>();
}
