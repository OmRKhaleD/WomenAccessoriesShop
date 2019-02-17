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
        public AccessoryController(IAccessoryRepository accessoryRepository)
        {
            _accessoryRepository = accessoryRepository;
        }
        public IActionResult Index()
        {
            return View(_accessoryRepository.GetAccessories());
        }
    }
}