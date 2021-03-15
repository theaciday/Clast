using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clast.Data.Models
{
    public class OrderDetail
    {
        public int Id{ get; set; }

        public int OrderId{ get; set; }

        public int LaptopId{ get; set; }

        public int Price{ get; set; }

        public virtual Laptop Laptop{ get; set; }

        public virtual Order Order{ get; set; }

        

    }
}
