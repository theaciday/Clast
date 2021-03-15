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
    public class HomeController:Controller
    {
        private ILaptop _laptoprep;
       

        public HomeController(ILaptop laptoprep)
        {
            _laptoprep = laptoprep;
        }

        public ViewResult Index()
        {
            var homeLaptop = new HomeViewModel
            {
                FavLaptops = _laptoprep.GetFavLaptops
            };
            return View(homeLaptop);
        }
    }
}
