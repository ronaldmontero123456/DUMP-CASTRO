using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dump_Catastro_CORE.Entities
{
    public class Formulariocatastral
    {
        public int Id { get; set; }

        public string? Codigo { get; set; }

        public string? FormJson { get; set; }
    }
}
