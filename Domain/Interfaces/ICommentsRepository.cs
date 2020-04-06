using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICommentsRepository : IBaseRepository<Comments>
    {
        Task<ICollection<Comments>> GetByNewsAsync(int newsId);
    }
}
