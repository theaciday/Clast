using System.Collections.Generic;
using Clast.Data.Models;

namespace Clast.Data.Interfaces
{
    public interface ILaptopCategory
    {
        IEnumerable<LaptopCategory> LaptopCategories { get; }

    }
    
}