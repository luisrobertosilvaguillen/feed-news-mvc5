using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class BaseService<T, TRepository> : IBaseService<T>
       where T : class, IEntity
       where TRepository : IBaseRepository<T>
    {
        private readonly TRepository repository;

        public BaseService(TRepository repository)
        {
            this.repository = repository;
        }
        public virtual async Task<T> CreateAsync(T entity)
        {
            return await repository.CreateAsync(entity);
        }
        public virtual async Task<T> UpdateAsync(int id, T entity)
        {
            return await repository.UpdateAsync(id, entity);
        }
        public virtual async Task<T> DeleteAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }
        public virtual async Task<T> FindAsync(int id)
        {
            return await repository.FindAsync(id);
        }
        public virtual async Task<ICollection<T>> GetAsync()
        {
            return await repository.GetAsync();
        }

    }
}
