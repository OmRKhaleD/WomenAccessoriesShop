using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenAccessoriesShop.Models
{
    public class MockAccessoryRepository : IAccessoryRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();


        public IEnumerable<Accessory> GetAccessories()
        {

                return new List<Accessory>
                {
                    new Accessory {AccessoryId = 1, Name="Dress", Price=15.95M, Description="Beautiful Dress", ImageUrl="/images/Dress_1.jpg",Category=_categoryRepository.GetCategories.ToList()[1]},
                    new Accessory {AccessoryId = 2, Name="Belt", Price=18.95M, Description="Wonderfull Belt",ImageUrl="/images/Belt_2.jpg",Category=_categoryRepository.GetCategories.ToList()[0]},
                    new Accessory {AccessoryId = 3, Name="Shoes", Price=15.95M, Description="Beautiful Shoes", ImageUrl="/images/ShoesFlat_3.jpg",Category=_categoryRepository.GetCategories.ToList()[2]},
                    new Accessory {AccessoryId = 4, Name="Belt", Price=12.95M, Description="Wonderfull Belt", ImageUrl="/images/Belt_1.jpg",Category=_categoryRepository.GetCategories.ToList()[0]}
                };
        }

        public Accessory GetAccessory(int AccessoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}
