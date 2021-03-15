using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data.Models;

namespace Clast.ViewModels
{
    public class LaptopListViewModel
    {
        public IEnumerable<Laptop> AllLaptops { get; set; }
        public string LaptopCategory { get; set; }

    }
}
