using Domain.DTO.Category;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        ICollection<NewsByCategory> GetNewsByCategory();
    }
}
