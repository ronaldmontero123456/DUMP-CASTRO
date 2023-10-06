using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AuthUser
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

    public virtual ICollection<AccountEmailaddress> AccountEmailaddresses { get; set; } = new List<AccountEmailaddress>();

    public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; } = new List<AuthUserGroup>();

    public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; set; } = new List<AuthUserUserPermission>();

    public virtual ICollection<DjangoAdminLog1> DjangoAdminLog1s { get; set; } = new List<DjangoAdminLog1>();

    public virtual ICollection<Otcatastro> Otcatastros { get; set; } = new List<Otcatastro>();
}
