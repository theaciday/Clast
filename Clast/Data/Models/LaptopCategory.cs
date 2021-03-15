using System.Collections.Generic;

namespace Clast.Data.Models
{
    public class LaptopCategory 
    {
        public int Id { get; set; }
        public string CategoryName{ get; set; }
        public string Desc { get; set; }
        public List<Laptop> Laptops  { get; set; }

    }
}
