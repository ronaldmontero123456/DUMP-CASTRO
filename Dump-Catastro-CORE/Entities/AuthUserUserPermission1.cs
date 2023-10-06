using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AuthUserUserPermission1
{
    public long Id { get; set; }

    public int UserId { get; set; }

    public int PermissionId { get; set; }

    public virtual AuthPermission Permission { get; set; } = null!;

    public virtual AuthUser1 User { get; set; } = null!;
}
