using System.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO.Category;
using Domain.Interfaces;
using Domain.Models;
using System.Linq;

namespace Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        protected readonly DataContext.DbContext DbContext;
        public CategoryRepository(DataContext.DbContext DbContext) : base(DbContext)
        {
            this.DbContext = DbContext;
        }

        public ICollection<NewsByCategory> GetNewsByCategory()
        {
            return DbContext.Categories
                .Include(f => f.News)
                .GroupBy(f => new { f.Id, f.Name })
                .Select(f => new NewsByCategory
                {
                    Category = f.Key.Name,
                    NewsQuantity = f.Select(x => x.News.Count).FirstOrDefault()
                })
                .OrderByDescending(f => f.NewsQuantity)
                .ToList();
        }
    }
}
