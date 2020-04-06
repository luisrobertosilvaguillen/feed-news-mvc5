using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories
{
    public class CommentsRepository : BaseRepository<Comments>, ICommentsRepository
    {
        protected readonly DataContext.DbContext DbContext;
        public CommentsRepository(DataContext.DbContext DbContext) : base(DbContext)
        {
            this.DbContext = DbContext;
        }

        public async Task<ICollection<Comments>> GetByNewsAsync(int newsId)
        {
            return await DbContext.Comments.Where(f => f.NewsId == newsId).ToListAsync();
        }
    }
}
