using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class DjangoContentType
{
    public int Id { get; set; }

    public string AppLabel { get; set; } = null!;

    public string Model { get; set; } = null!;

    public virtual ICollection<AuthPermission1> AuthPermission1s { get; set; } = new List<AuthPermission1>();

    public virtual ICollection<DjangoAdminLog1> DjangoAdminLog1s { get; set; } = new List<DjangoAdminLog1>();
}
