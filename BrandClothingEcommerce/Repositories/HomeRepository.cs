using BrandClothingEcommerce.Data;
using BrandClothingEcommerce.Models;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;

namespace BrandClothingEcommerce.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;
        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<TypeOfСlothing>> TypeOfСlothing()
        {
            return await _db.TypeOfСlothing.ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetProduct(string sTerm = "", int typeOfСlothingId = 0)
        {
            sTerm = sTerm.ToLower();
            IEnumerable<Product> products = await (from product in _db.Products
                                             join typeOfСlothing in _db.TypeOfСlothing
                                             on product.TypeOfСlothingId equals typeOfСlothing.Id
                                             where string.IsNullOrWhiteSpace(sTerm) || (product != null && product.ProductName.ToLower().StartsWith(sTerm))
                                             select new Product
                                             {
                                                 Id = product.Id,
                                                 Image = product.Image,
                                                 ProductName = product.ProductName,
                                                 TypeOfСlothingId = product.TypeOfСlothingId,
                                                 Price = product.Price,
                                                 TypeName = typeOfСlothing.TypeName
                                             }  
                         ).ToListAsync();
            if (typeOfСlothingId > 0)
            {
                products = products.Where(a => a.TypeOfСlothingId == typeOfСlothingId).ToList();
            }
            return products;
        }
    }
}
