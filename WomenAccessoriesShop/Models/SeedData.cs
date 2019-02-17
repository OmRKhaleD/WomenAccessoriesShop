using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenAccessoriesShop.Models
{
    public static class SeedData
    {
        public static void EnsureSeedDataForContext(this AccessoriesDbContext context)
        {
            // first, clear the database.  This ensures we can always start 
            // fresh with each demo
            if (!context.Accessories.Any())
            {
                List<Accessory> accessories = new List<Accessory>
            {
                new Accessory {Name="Dress", Price=15.95M, Description="Beautiful Dress", ImageUrl="/images/Dress_1.jpg",Category=Categories()["Dresses"] },
                new Accessory {Name="Belt", Price=18.95M, Description="Wonderfull Belt",ImageUrl="/images/Belt_2.jpg",Category=Categories()["Belts"]},
                new Accessory {Name="Shoes", Price=15.95M, Description="Beautiful Shoes", ImageUrl="/images/ShoesFlat_3.jpg",Category=Categories()["Shoes"]},
                new Accessory {Name="Bag", Price=12.95M, Description="Wonderfull Bag", ImageUrl="/images/Bag_1.jpg",Category=Categories()["Bags"]},
                new Accessory {Name="Hat", Price=13.95M, Description="Beautiful Hat", ImageUrl="/images/Hat_2.jpg",Category=Categories()["Hats"]},
                new Accessory {Name="Scarf", Price=16.95M, Description="Wonderfull Scarf", ImageUrl="/images/Scarf_3.jpg",Category=Categories()["Scarfs & Wraps"]},
                new Accessory {Name="Ring", Price=19.95M, Description="Beautiful Ring", ImageUrl="/images/Ring_1.jpg",Category=Categories()["Rings"]},
                new Accessory {Name="Gloves", Price=14.95M, Description="Wonderfull Gloves", ImageUrl="/images/Gloves_2.jpg",Category=Categories()["Gloves"]},
                new Accessory {Name="Glasses", Price=11.95M, Description="Beautiful Glasses", ImageUrl="/images/Glasses_3.jpg",Category=Categories()["Glasses"]},
                new Accessory {Name="Wallet", Price=17.95M, Description="Wonderfull Wallet", ImageUrl="/images/Wallet_1.jpg",Category=Categories()["Wallets"]},
                new Accessory {Name="Face Mask", Price=22.95M, Description="Beautiful Face Mask", ImageUrl="/images/Face_Mask_3.jpg",Category=Categories()["Face Masks"]},
                new Accessory {Name="Neck Gaiter", Price=20.95M, Description="Wonderfull Neck Gaiter", ImageUrl="/images/Neck_Gaiter_2.jpg",Category=Categories()["Neck Gaiters"]},
            };
                context.Accessories.AddRange(accessories);
            }
            // init seed data
            if(!context.Categories.Any())
                context.Categories.AddRange(Categories().Select(c => c.Value));

            context.SaveChanges();
        }
        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories()
        {
            if (categories == null)
            {
                var genresList = new Category[]
                {
                    new Category{CategoryName="Belts"},
                    new Category{CategoryName="Dresses"},
                    new Category{CategoryName="Shoes"},
                    new Category{CategoryName="Bags"},
                    new Category{CategoryName="Gloves"},
                    new Category{CategoryName="Rings"},
                    new Category{ CategoryName="Hats"},
                    new Category{CategoryName="Scarfs & Wraps"},
                    new Category{CategoryName="Glasses"},
                    new Category{CategoryName="Face Masks"},
                    new Category{CategoryName="Neck Gaiters"},
                    new Category{CategoryName="Wallets"}
                };
                categories = new Dictionary<string, Category>();
                foreach (Category genre in genresList)
                {
                    categories.Add(genre.CategoryName, genre);
                }
            }
            return categories;
        }
    }
}

