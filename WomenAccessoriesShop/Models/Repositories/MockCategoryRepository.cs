using System.Collections.Generic;

namespace WomenAccessoriesShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Belts"},
                    new Category{CategoryId=2, CategoryName="Dresses"},
                    new Category{CategoryId=3, CategoryName="Shoes"}
                };
            }
        }
    }
}