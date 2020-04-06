using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repositories.DataContext;
using System.Data.Entity;

namespace Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity
    {
        protected readonly DataContext.DbContext DbContext;
        public BaseRepository(DataContext.DbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            DbContext.Set<T>().Add(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> DeleteAsync(int id)
        {
            T entity = await FindAsync(id);
            if (entity == null)
                return entity;

            DbContext.Entry(entity).State = EntityState.Deleted;
            DbContext.Set<T>().Remove(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<T> FindAsync(int id)
        {
            return await DbContext.Set<T>().Where(d => !d.Deleted && d.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<ICollection<T>> GetAsync()
        {
            return await DbContext.Set<T>().Where(d=> !d.Deleted).ToListAsync();
        }

        public virtual async Task<T> LogicalDeleteAsync(int id)
        {
            T entity = await FindAsync(id);
            if (entity == null)
                return entity;

            entity.Deleted = true;
            DbContext.Entry(entity).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<T> UpdateAsync(int id, T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
            return entity;
        }
    }
}
