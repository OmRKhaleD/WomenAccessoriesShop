using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenAccessoriesShop.Models
{
    public class AccessoryRepository : IAccessoryRepository
    {
        AccessoriesDbContext _dbContext;
        public AccessoryRepository(AccessoriesDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<Accessory> GetAccessories()
        {
            return _dbContext.Accessories.Include(c => c.Category);
        }

        public Accessory GetAccessory(int AccessoryId)
        {
            return _dbContext.Accessories.FirstOrDefault(a => a.AccessoryId == AccessoryId);
        }
    }
}
