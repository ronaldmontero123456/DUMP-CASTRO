using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Provincia
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int Departamento { get; set; }

    public int Codigo { get; set; }

    public virtual Departamento DepartamentoNavigation { get; set; } = null!;

    public virtual ICollection<Distrito> Distritos { get; set; } = new List<Distrito>();
}
