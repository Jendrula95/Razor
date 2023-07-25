using System.ComponentModel;
using System.Xml.Linq;

namespace Razor.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [DisplayName("Produkt")]
        public string Name { get;  set; }
        public string Description { get; set; }
        [DisplayName("Cena")]
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
