namespace Dump_Catastro_CORE.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IVistaCatastroRepository VistaCatastroRepository { get;}
        public IVistaTerrenosRepository VistaTerrenosRepository { get;}
        public IVistaConstruccioneRepository VistaConstruccioneRepository { get;}
        public IFormularioCatastralRepository FormularioCatastralRepository { get;}
        Task SaveChangesAsync();
    }
}
