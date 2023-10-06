using Dump_Catastro_CORE.Entities;
using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;

namespace Dump_Catastro_INFRASTRUCTURE.Repositories
{
    public class VistaTerrenosRepository : BaseRepository<VistaTerreno>, IVistaTerrenosRepository
    {
        public VistaTerrenosRepository(DbcatastroContext dbcatastroContext) : base(dbcatastroContext){}
    }
}
