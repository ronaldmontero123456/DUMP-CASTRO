using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AuthGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AuthGroupPermission1> AuthGroupPermission1s { get; set; } = new List<AuthGroupPermission1>();

    public virtual ICollection<AuthUserGroup1> AuthUserGroup1s { get; set; } = new List<AuthUserGroup1>();
}
