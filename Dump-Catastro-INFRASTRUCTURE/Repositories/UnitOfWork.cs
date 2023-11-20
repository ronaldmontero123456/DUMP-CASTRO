using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;

namespace Dump_Catastro_INFRASTRUCTURE.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbcatastroContext _context;

        private readonly IVistaCatastroRepository _vistaCatastroRepository;
        private readonly IVistaTerrenosRepository _vistaTerrenosRepository;
        private readonly IVistaConstruccioneRepository _vistaConstruccioneRepository;        
        private readonly IFormularioCatastralRepository _formularioCatastralRepository;        

        public UnitOfWork(DbcatastroContext context)
        {
            _context = context;
        }

        public IVistaCatastroRepository VistaCatastroRepository => _vistaCatastroRepository ?? new VistaCatastroRepository(_context);
        public IVistaTerrenosRepository VistaTerrenosRepository => _vistaTerrenosRepository ?? new VistaTerrenosRepository(_context);
        public IVistaConstruccioneRepository VistaConstruccioneRepository => _vistaConstruccioneRepository ?? new VistaConstruccioneRepository(_context);
        public IFormularioCatastralRepository FormularioCatastralRepository => _formularioCatastralRepository ?? new FormularioCatastralRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
