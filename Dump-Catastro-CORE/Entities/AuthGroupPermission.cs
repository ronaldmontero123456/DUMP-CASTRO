using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AuthGroupPermission
{
    public long Id { get; set; }

    public int GroupId { get; set; }

    public int PermissionId { get; set; }

    public virtual AuthGroup1 Group { get; set; } = null!;

    public virtual AuthPermission1 Permission { get; set; } = null!;
}
