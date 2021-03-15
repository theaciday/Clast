using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data.Interfaces;
using Clast.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Clast.Data.Repository
{
    public class LaptopRepository : ILaptop
    {
        private readonly AppDbContext _appDbContext;

        public LaptopRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Laptop> Laptops => _appDbContext.Laptops.Include(c => c.LaptopCategory);
        public IEnumerable<Laptop> GetFavLaptops => _appDbContext.Laptops.Where(l => l.IsFavourite);
        public Laptop GetLaptop(int laptopId) => _appDbContext.Laptops.FirstOrDefault(l=>l.Id==laptopId);

    }
}
