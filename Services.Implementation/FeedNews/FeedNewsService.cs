using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Services.FeedNews;
using Domain.DTO.FeedNews;

namespace Services.Implementation.FeedNews
{
    public class FeedNewsService : BaseService<Domain.Models.FeedNews, IFeedNewsRepository>, IFeedNewsService
    {
        protected readonly IFeedNewsRepository feedNewsRepository;
        public FeedNewsService(IFeedNewsRepository feedNewsRepository) : base(feedNewsRepository)
        {
            this.feedNewsRepository = feedNewsRepository;
        }

        public Task<ICollection<Domain.Models.FeedNews>> GetByCategoryAsync(int newsCategoryId)
        {
            return this.feedNewsRepository.GetByCategoryAsync(newsCategoryId);
        }

        public  ICollection<NewsByFeedNews> GetNewsByFeedNews(int take = 0)
        {
            var feeds =  feedNewsRepository.GetNewsByFeedNews();
            if (take > 0)
                return feeds.Take(take).ToList();
            return feeds;
        }
    }
}
