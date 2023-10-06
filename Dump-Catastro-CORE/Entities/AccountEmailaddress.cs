using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AccountEmailaddress
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public bool Verified { get; set; }

    public bool Primary { get; set; }

    public int UserId { get; set; }

    public virtual AuthUser User { get; set; } = null!;
}
