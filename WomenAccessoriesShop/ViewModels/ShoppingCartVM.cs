using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WomenAccessoriesShop.Models;

namespace WomenAccessoriesShop.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
