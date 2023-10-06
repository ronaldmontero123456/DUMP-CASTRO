using System;
using System.Collections.Generic;

namespace Dump_Catastro_CORE.Entities;

public partial class Localidade
{
    public int Id { get; set; }

    public string? Municipio { get; set; }

    public int? Departamento { get; set; }

    public int? Distrito { get; set; }

    public int? Provincia { get; set; }

    public string? Descripcion { get; set; }
}
