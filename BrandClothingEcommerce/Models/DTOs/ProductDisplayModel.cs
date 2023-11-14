using Humanizer.Localisation;

namespace BrandClothingEcommerce.Models.DTOs
{
    public class ProductDisplayModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<TypeOfСlothing> TypeOfСlothing { get; set; }
        public string STerm { get; set; } = "";
        public int TypeOfСlothingId { get; set; } = 0;
    }
}
