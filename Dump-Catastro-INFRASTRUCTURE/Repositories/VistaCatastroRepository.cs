using Dump_Catastro_CORE.Entities;
using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;

namespace Dump_Catastro_INFRASTRUCTURE.Repositories
{
    public class VistaCatastroRepository : BaseRepository<VistaCatastro>, IVistaCatastroRepository
    {
        public VistaCatastroRepository(DbcatastroContext dbcatastroContext) : base(dbcatastroContext) { }
    }
}
