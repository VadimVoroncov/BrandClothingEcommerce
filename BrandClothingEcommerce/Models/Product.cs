﻿using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BrandClothingEcommerce.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int TypeOfСlothingId { get; set; }
        public TypeOfСlothing TypeOfСlothing { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }
        [NotMapped]
        public string TypeName { get; set; }
        //public ProductStatus ProductStatus { get; set; }
    }
}
