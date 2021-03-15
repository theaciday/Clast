namespace Clast.Data.Models
{
    public class Laptop  
    {
        public int Id{ get; set; }

        public string Name{ get; set; }
        
        public string ShortDesc{ get; set; }
        
        public string LongDesc{ get; set; }
        
        public string Img{ get; set; }
        
        public int Price{ get; set; }
        
        public bool IsFavourite{ get; set; }

        public bool IsAvailable{ get; set; }

        public int CategoryId{ get; set; }
        
        public LaptopCategory LaptopCategory{ get; set; }
    }
}
