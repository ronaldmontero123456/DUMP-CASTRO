using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class DjangoContentType1
{
    public int Id { get; set; }

    public string AppLabel { get; set; } = null!;

    public string Model { get; set; } = null!;

    public virtual ICollection<AuthPermission> AuthPermissions { get; set; } = new List<AuthPermission>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; } = new List<DjangoAdminLog>();
}
