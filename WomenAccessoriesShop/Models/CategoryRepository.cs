using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenAccessoriesShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        AccessoriesDbContext _dbContext;
        public CategoryRepository(AccessoriesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Category> GetCategories => _dbContext.Categories;
    }
}
