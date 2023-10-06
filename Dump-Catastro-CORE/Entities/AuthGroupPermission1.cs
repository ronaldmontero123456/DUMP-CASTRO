using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AuthGroupPermission1
{
    public long Id { get; set; }

    public int GroupId { get; set; }

    public int PermissionId { get; set; }

    public virtual AuthGroup Group { get; set; } = null!;

    public virtual AuthPermission Permission { get; set; } = null!;
}
