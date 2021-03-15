namespace Clast.Data.Models
{
    public class ShopCartItem
    {
        public int Id{ get; set; }
        public Laptop Laptop { get; set; }
        public int Price { get; set; }

        public string ShopCartId { get; set; }
    }
}
