using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data.Models;

namespace Clast.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Laptop> FavLaptops { get; set; }
    }
}
