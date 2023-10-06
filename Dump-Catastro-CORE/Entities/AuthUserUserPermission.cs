using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AuthUserUserPermission
{
    public long Id { get; set; }

    public int UserId { get; set; }

    public int PermissionId { get; set; }

    public virtual AuthPermission1 Permission { get; set; } = null!;

    public virtual AuthUser User { get; set; } = null!;
}
