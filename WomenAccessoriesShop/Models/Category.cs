using System.Collections.Generic;

namespace WomenAccessoriesShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Accessory> Accessories { get; set; }
    }
}