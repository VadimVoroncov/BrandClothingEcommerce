using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrandClothingEcommerce.Models
{
    [Table("TypeOfСlothing")]
    public class TypeOfСlothing
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string TypeName { get; set; }
        public List<Product> Products { get; set; }
    }
}
