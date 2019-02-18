using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WomenAccessoriesShop.Models;

namespace WomenAccessoriesShop.Controllers
{
    public class HomeController : Controller
    {
        IAccessoryRepository _accessoryRepository;
        public HomeController(IAccessoryRepository accessoryRepository)
        {
            _accessoryRepository = accessoryRepository;
        }
        public IActionResult Index(string category)
        {
            IEnumerable<Accessory> accessories;
            if (string.IsNullOrEmpty(category))
                accessories = _accessoryRepository.GetAccessories();
            else
                accessories =_accessoryRepository.GetAccessories().Where(a => a.Category.CategoryName == category).OrderBy(a => a.Name);
            return View(accessories);
        }
        public IActionResult Details(int id)
        {
            var cloth = _accessoryRepository.GetAccessory(id);
            if (cloth == null)
            {
                return NotFound();
            }
            return View(cloth);
        }
    }
}