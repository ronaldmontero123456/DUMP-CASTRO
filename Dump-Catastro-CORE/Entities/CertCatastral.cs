using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class CertCatastral
{
    public short Id { get; set; }

    public DateOnly Fecha { get; set; }

    public Guid Uuid { get; set; }
}
