using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        protected readonly DataContext.DbContext DbContext;

        public NewsRepository(DataContext.DbContext DbContext) : base(DbContext)
        {
            this.DbContext = DbContext;
        }
        public async Task<ICollection<News>> GetByFeedNewsAsync(int feedNewsId)
        {
            return await DbContext.News.Where(f => f.FeedNewsId == feedNewsId).ToListAsync();
        }

        public async Task<ICollection<News>> GetByCategoryAsync(int categoryId)
        {
            return await DbContext.News
                .Include(f=> f.Comments)
                .Where(f => f.CategoryId == categoryId).ToListAsync();
        }
    }
}
