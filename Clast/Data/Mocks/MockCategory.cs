using System.Collections.Generic;
using Clast.Data.Interfaces;
using Clast.Data.Models;

namespace Clast.Data.Mocks
{
    public class MockCategory : ILaptopCategory
    {
        public IEnumerable<LaptopCategory> LaptopCategories
        {
            get
            {
                return new List<LaptopCategory>
                {
                    new LaptopCategory{CategoryName = "Бизнес-ноутбук",Desc = "Для работы"},
                    new LaptopCategory {CategoryName = "Игровой",Desc = "Для игр"}
                };
            }
        }
    }
}