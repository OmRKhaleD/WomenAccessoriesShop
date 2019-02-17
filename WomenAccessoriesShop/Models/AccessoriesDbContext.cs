using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenAccessoriesShop.Models
{
    public class AccessoriesDbContext : DbContext
    {
        public AccessoriesDbContext(DbContextOptions<AccessoriesDbContext> options) : base(options)
        {

        }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
