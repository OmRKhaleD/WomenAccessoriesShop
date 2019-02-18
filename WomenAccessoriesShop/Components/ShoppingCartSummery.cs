using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WomenAccessoriesShop.Models;
using WomenAccessoriesShop.ViewModels;

namespace WomenAccessoriesShop.Components
{
    public class ShoppingCartSummery : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummery(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            //var items = new List<ShoppingCartItem>() { new ShoppingCartItem()};
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartVM
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
