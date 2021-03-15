using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Clast.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContext _appDbContext;

        public ShopCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public string Id{ get; set; }

        public List<ShopCartItem> ListItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string shopCartId = session.GetString("Id")?? Guid.NewGuid().ToString();
            session.SetString("Id",shopCartId);
            return new ShopCart(context) {Id = shopCartId};
        }

        public void AddToCart(Laptop laptop)
        {
            _appDbContext.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = Id,
                Price = laptop.Price,
                Laptop = laptop
                
            });
            _appDbContext.SaveChanges();
        }

        public List<ShopCartItem> GetItems()
        {
            return _appDbContext.ShopCartItems.Where(c => c.ShopCartId == Id).Include(s => s.Laptop).ToList();

        }
    }
}
