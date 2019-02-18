using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WomenAccessoriesShop.Models;
using WomenAccessoriesShop.ViewModels;

namespace WomenAccessoriesShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IAccessoryRepository _accessoryRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IAccessoryRepository accessoryRepository, ShoppingCart shoppingCart)
        {
            _accessoryRepository = accessoryRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartVM
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int accessoryId)
        {
            var selectedAccessory = _accessoryRepository.GetAccessories().FirstOrDefault(p => p.AccessoryId == accessoryId);

            if (selectedAccessory != null)
            {
                _shoppingCart.AddToCart(selectedAccessory, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int accessoryId)
        {
            var selectedPie = _accessoryRepository.GetAccessories().FirstOrDefault(p => p.AccessoryId == accessoryId);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}