﻿using BrandClothingEcommerce.Models;
using Humanizer.Localisation;

namespace BrandClothingEcommerce
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Product>> GetProduct(string sTerm = "", int typeOfСlothingId = 0);
        Task<IEnumerable<TypeOfСlothing>> TypeOfСlothing();
        //Task<Product> GetProductById(int productId);
        //void UpdateProduct(Product product);
        //void DeleteProduct(Product product);
    }
}