using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data.Interfaces;
using Clast.Data.Models;
using Clast.Data.Repository;
using Clast.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clast.Controllers
{
    public class ShopCartController:Controller
    {
        private readonly ILaptop _laptoprep;
        private readonly ShopCart _shopCart;

        public ShopCartController(ILaptop laptoprep,ShopCart shopCart)
        public ShopCartController(ILaptop laptoprep, ShopCart shopCart)
        {
            _shopCart = shopCart;
            _laptoprep = laptoprep;

        }

        public ViewResult Index()
        {
            var items = _shopCart.GetItems();
            _shopCart.ListItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _laptoprep.Laptops.FirstOrDefault(i=>i.Id==id );
            if (item!=null)
            {
                _shopCart.AddToCart(item);

            }

            return RedirectToAction("Index");

        }
    }
}
