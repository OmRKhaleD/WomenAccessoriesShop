using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WomenAccessoriesShop.Models;
using WomenAccessoriesShop.ViewModels;

namespace WomenAccessoriesShop.Controllers
{
    [Route("api/[controller]")]
    public class AccessoriesDataController : Controller
    {
        private readonly IAccessoryRepository _accessoryRepository;

        public AccessoriesDataController(IAccessoryRepository accessoryRepository)
        {
            _accessoryRepository = accessoryRepository;
        }

        [HttpGet]
        public IActionResult LoadMoreAccessories(int pageIndex,int pageSize)
        {
            IEnumerable<Accessory> dbAccessories = null;

            dbAccessories = _accessoryRepository.GetAccessories().OrderBy(a => a.AccessoryId).Skip(pageIndex * pageSize).Take(pageSize); 

            List<AccessoryVM> accessories = new List<AccessoryVM>();

            foreach (var dbAccessory in dbAccessories)
            {
                accessories.Add(MapDbAccessoryTAccessoryViewModel(dbAccessory));
            }
            return Ok(accessories);
        }

        private AccessoryVM MapDbAccessoryTAccessoryViewModel(Accessory dbAccessory)
        {
            return new AccessoryVM()
            {
                AccessoryId = dbAccessory.AccessoryId,
                Name = dbAccessory.Name,
                Price = dbAccessory.Price,
                Description = dbAccessory.Description,
                ImageUrl = dbAccessory.ImageUrl
            };
        }
    }
}