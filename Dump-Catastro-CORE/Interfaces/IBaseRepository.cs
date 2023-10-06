using System.Linq.Expressions;

namespace Dump_Catastro_CORE.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        void Update(T entity);
        Task Delete(int id);
        IQueryable<T> Search(Expression<Func<T, bool>> query);
    }
}
