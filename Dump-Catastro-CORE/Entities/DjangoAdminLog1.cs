using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class DjangoAdminLog1
{
    public int Id { get; set; }

    public DateTime ActionTime { get; set; }

    public string? ObjectId { get; set; }

    public string ObjectRepr { get; set; } = null!;

    public short ActionFlag { get; set; }

    public string ChangeMessage { get; set; } = null!;

    public int? ContentTypeId { get; set; }

    public int UserId { get; set; }

    public virtual DjangoContentType? ContentType { get; set; }

    public virtual AuthUser User { get; set; } = null!;
}
