using System.Collections.Generic;
using Clast.Data.Models;

namespace Clast.Data.Interfaces
{
    public interface ILaptop
    {
        IEnumerable<Laptop> Laptops { get; }
        IEnumerable<Laptop> GetFavLaptops { get; }
        Laptop GetLaptop(int laptopId);

    }
}