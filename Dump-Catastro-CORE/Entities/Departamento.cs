using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Departamento
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Distrito> Distritos { get; set; } = new List<Distrito>();

    public virtual ICollection<Provincia> Provincia { get; set; } = new List<Provincia>();
}
