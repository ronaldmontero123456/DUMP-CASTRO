﻿using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AuthUser1
{
    public int Id { get; set; }

    public string Password { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    public bool IsSuperuser { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool IsStaff { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateJoined { get; set; }

    public virtual ICollection<AuthUserGroup1> AuthUserGroup1s { get; set; } = new List<AuthUserGroup1>();

    public virtual ICollection<AuthUserUserPermission1> AuthUserUserPermission1s { get; set; } = new List<AuthUserUserPermission1>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; } = new List<DjangoAdminLog>();
}
