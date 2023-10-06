using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class DjangoSession1
{
    public string SessionKey { get; set; } = null!;

    public string SessionData { get; set; } = null!;

    public DateTime ExpireDate { get; set; }
}
