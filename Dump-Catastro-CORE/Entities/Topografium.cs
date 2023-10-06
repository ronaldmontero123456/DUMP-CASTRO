using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Topografium
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public float? Valor { get; set; }

    public virtual ICollection<Terrenos19> Terrenos19s { get; set; } = new List<Terrenos19>();
}
