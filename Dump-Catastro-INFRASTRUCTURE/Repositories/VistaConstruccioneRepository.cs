using Dump_Catastro_CORE.Entities;
using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;

namespace Dump_Catastro_INFRASTRUCTURE.Repositories
{
    public class VistaConstruccioneRepository : BaseRepository<VistaConstruccionesJbo>, IVistaConstruccioneRepository
    {
        public VistaConstruccioneRepository(DbcatastroContext dbcatastroContext) : base(dbcatastroContext) { }
    }
}
