using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.News
{
    public interface INewsService: IBaseService<Domain.Models.News>
    {
        Task<ICollection<Domain.Models.News>> GetByFeedNewsAsync(int feedNewsId);
        Task<ICollection<Domain.Models.News>> GetByCategoryAsync(int categoryId);
    }
}
