using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Services.Category;
using Domain.DTO.Category;
using System.Linq;

namespace Services.Implementation.Category
{
    public class CategoryService : BaseService<Domain.Models.Category, ICategoryRepository>, ICategoryService
    {
        protected readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public ICollection<NewsByCategory> GetNewsByCategory(int take = 0)
        {
            var categories = categoryRepository.GetNewsByCategory();
            if (take > 0)
                return categories.Take(take).ToList();
            return categories;
        }
    }
}
