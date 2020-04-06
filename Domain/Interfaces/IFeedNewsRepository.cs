using Domain.DTO.FeedNews;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFeedNewsRepository : IBaseRepository<FeedNews>
    {
        Task<ICollection<FeedNews>> GetByCategoryAsync(int newsCategoryId);
        ICollection<NewsByFeedNews> GetNewsByFeedNews();
    }
}
