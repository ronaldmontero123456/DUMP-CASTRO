using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class AuthPermission
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ContentTypeId { get; set; }

    public string Codename { get; set; } = null!;

    public virtual ICollection<AuthGroupPermission1> AuthGroupPermission1s { get; set; } = new List<AuthGroupPermission1>();

    public virtual ICollection<AuthUserUserPermission1> AuthUserUserPermission1s { get; set; } = new List<AuthUserUserPermission1>();

    public virtual DjangoContentType1 ContentType { get; set; } = null!;
}
