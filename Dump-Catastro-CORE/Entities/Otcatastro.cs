using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Otcatastro
{
    public int Id { get; set; }

    public int? Idusuario { get; set; }

    public int? Idlote { get; set; }

    public virtual Terrenos19? IdloteNavigation { get; set; }

    public virtual AuthUser? IdusuarioNavigation { get; set; }
}
