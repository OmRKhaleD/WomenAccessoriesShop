using System.Collections.Generic;

namespace WomenAccessoriesShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }
}