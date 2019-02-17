using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WomenAccessoriesShop.Models;

namespace WomenAccessoriesShop.Controllers
{
    public class AccessoryController : Controller
    {
        IAccessoryRepository _accessoryRepository;
        ICategoryRepository _categoryRepository;
        public AccessoryController(IAccessoryRepository accessoryRepository,ICategoryRepository categoryRepository)
        {
            _accessoryRepository = accessoryRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(_accessoryRepository.GetAccessories);
        }
    }
}