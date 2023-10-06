using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Dump_Catastro_INFRASTRUCTURE.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbSet<T> dbSet;

        public BaseRepository(DbcatastroContext Context)
        {
            dbSet = Context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking().AsEnumerable();
        }

        public async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public IQueryable<T> Search(Expression<Func<T,bool>> query)
        {
            return dbSet.AsNoTracking().AsQueryable().Where(query);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
