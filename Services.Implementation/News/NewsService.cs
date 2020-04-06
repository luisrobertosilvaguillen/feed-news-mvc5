using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Services.News;

namespace Services.Implementation.News
{
    public class NewsService : BaseService<Domain.Models.News, INewsRepository>, INewsService
    {
        protected readonly INewsRepository newsRepository;
        public NewsService(INewsRepository newsRepository) : base(newsRepository)
        {
            this.newsRepository = newsRepository;
        }

        public Task<ICollection<Domain.Models.News>> GetByFeedNewsAsync(int feedNewsId)
        {
            return newsRepository.GetByFeedNewsAsync(feedNewsId);
        }

        public Task<ICollection<Domain.Models.News>> GetByCategoryAsync(int categoryId)
        {
            return newsRepository.GetByCategoryAsync(categoryId);
        }
    }
}
