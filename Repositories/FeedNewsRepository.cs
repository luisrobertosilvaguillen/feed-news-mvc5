using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.DTO.FeedNews;

namespace Repositories
{
    public class FeedNewsRepository : BaseRepository<FeedNews>, IFeedNewsRepository
    {
        protected readonly DataContext.DbContext DbContext;
        public FeedNewsRepository(DataContext.DbContext DbContext) : base(DbContext)
        {
            this.DbContext = DbContext;
        }
        public override async Task<ICollection<FeedNews>> GetAsync()
        {
            return await DbContext.FeedNews
                .Include(f => f.News)
                .Where(d => !d.Deleted)
                .ToListAsync();
        }
        public async Task<ICollection<FeedNews>> GetByCategoryAsync(int categoryId)
        {
            return await DbContext.FeedNews
                .Include(f => f.Categories)
                .Where(f => f.Categories.Count(d => d.Id == categoryId) > 0)
                .ToListAsync();
        }

        public ICollection<NewsByFeedNews> GetNewsByFeedNews()
        {
            return DbContext.FeedNews
                .Include(f => f.News)
                .GroupBy(f => new { f.Id, f.Name })
                .Select(f => new NewsByFeedNews
                {
                    FeedNews = f.Key.Name,
                    NewsQuantity = f.Select(x => x.News.Count).FirstOrDefault()
                })
                .OrderByDescending(f => f.NewsQuantity)
                .ToList();
        }
    }
}
