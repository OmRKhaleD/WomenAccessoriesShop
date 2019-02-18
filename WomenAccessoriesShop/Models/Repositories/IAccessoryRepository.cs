using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenAccessoriesShop.Models
{
    public interface IAccessoryRepository
    {
        IEnumerable<Accessory> GetAccessories();
        Accessory GetAccessory(int AccessoryId);
    }
}
