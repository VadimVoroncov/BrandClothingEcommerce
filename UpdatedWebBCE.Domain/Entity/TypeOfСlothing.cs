using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedWebBCE.Domain.Entity
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
