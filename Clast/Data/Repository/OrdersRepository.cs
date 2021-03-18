using Clast.Data.Interfaces;
using Clast.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clast.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContext appDbContext;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDbContext appDbContext,ShopCart shopCart)
        {
            this.appDbContext = appDbContext;
            this.shopCart = shopCart;
        }
        public void СreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContext.Order.Add(order);

            var items = shopCart.ListItems;
                
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    LaptopId = el.Laptop.Id,
                    OrderId = order.Id,
                    Price = el.Laptop.Price


                };
                appDbContext.OrderDetail.Add(orderDetail);
            }
            appDbContext.SaveChanges();
        }
    }
}
