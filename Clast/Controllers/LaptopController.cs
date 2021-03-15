using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data.Interfaces;
using Clast.Data.Models;
using Clast.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clast.Controllers
{
    public class LaptopController:Controller
    {
        private readonly ILaptop _allLaptop;
        private readonly ILaptopCategory _laptopCategory;

        public LaptopController(ILaptop allLaptop,ILaptopCategory laptopCategory)
        {
            _allLaptop = allLaptop;
            _laptopCategory = laptopCategory;
        }

        [Route("Laptops/List")]
        [Route("Laptops/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Laptop> llaptops=null;
            string laptopCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                llaptops = _allLaptop.Laptops.OrderBy(i => i.Id);

            }
            else
            {
                if (string.Equals("gaming", category, StringComparison.OrdinalIgnoreCase))
                {
                    llaptops = _allLaptop.Laptops.Where(i => i.LaptopCategory.CategoryName.Equals("Игровой")).OrderBy(i => i.Id);
                    laptopCategory = "Игровой";
                }
                else if (string.Equals("business", category, StringComparison.OrdinalIgnoreCase))   
                {
                    llaptops = _allLaptop.Laptops.Where(i => i.LaptopCategory.CategoryName.Equals("Бизнес-ноутбук")).OrderBy(i => i.Id);
                    laptopCategory = "Бизнес-ноутбук";
                }
                laptopCategory = _category;


            }
            var laptopObject = new LaptopListViewModel
            {
                AllLaptops = llaptops,
                LaptopCategory = laptopCategory,

            };

            ViewBag.Title = "Ноутбуки";
            return View(laptopObject);
        }
    }
}
