using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<T> FindAsync(int id);
        Task<ICollection<T>> GetAsync();
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(int id, T entity);
        Task<T> DeleteAsync(int id);
        Task<T> LogicalDeleteAsync(int id);
    }
}
