    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    using Clast.Data.Interfaces;
using Clast.Data.Models;

namespace Clast.Data.Repository
{
    public class LaptopCategoryRepository : ILaptopCategory
    {
        private readonly AppDbContext _appDbContext;

        public LaptopCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<LaptopCategory> LaptopCategories => _appDbContext.Categories;
    }
}
