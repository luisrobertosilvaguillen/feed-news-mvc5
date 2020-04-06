using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface INewsRepository : IBaseRepository<News>
    {
        Task<ICollection<News>> GetByFeedNewsAsync(int feedNewsId);
        Task<ICollection<News>> GetByCategoryAsync(int categoryId);
    }
}
