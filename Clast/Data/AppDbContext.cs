using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Clast.Data
{
    public class AppDbContext:DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public  DbSet<Laptop> Laptops { get; set; }
        public DbSet<LaptopCategory> Categories { get; set; }
        public DbSet<ShopCartItem> ShopCartItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }



    }
}
