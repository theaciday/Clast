using Clast.Data;
using Clast.Data.Interfaces;
using Clast.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clast.Controllers
{
    public class OrderController:Controller
    {
       
        private readonly IAllOrders allorders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allorders = allOrders;
            this.shopCart = shopCart;
        }
        public IActionResult CheckOut() 
        {

            return View();
        }
    }
}
