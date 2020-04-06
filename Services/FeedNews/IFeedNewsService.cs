using Domain.DTO.FeedNews;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.FeedNews
{
    public interface IFeedNewsService : IBaseService<Domain.Models.FeedNews>
    {
        Task<ICollection<Domain.Models.FeedNews>> GetByCategoryAsync(int newsCategoryId);
        ICollection<NewsByFeedNews> GetNewsByFeedNews(int take = 0);
    }
}
