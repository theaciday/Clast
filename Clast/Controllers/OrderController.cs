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
            allorders = allOrders;
            this.shopCart = shopCart;            
        }
        public IActionResult Checkout() 
        {

            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.ListItems = shopCart.GetItems();
            if (shopCart.ListItems.Count == 0)
            {
                ModelState.AddModelError("", "Cart cant be empty!");
            }
            else if (ModelState.IsValid)
            {
                allorders.СreateOrder(order);
                return RedirectToAction("Complete  ");
            }
            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Order is sucсessful processed ";
            return View();
        }
    }
}
