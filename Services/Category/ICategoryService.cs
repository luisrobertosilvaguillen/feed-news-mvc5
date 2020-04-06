using Domain.DTO.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Category
{
    public interface ICategoryService : IBaseService<Domain.Models.Category>
    {
        ICollection<NewsByCategory> GetNewsByCategory(int take = 0);
    }
}
