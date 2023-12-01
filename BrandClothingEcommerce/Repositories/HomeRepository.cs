using BrandClothingEcommerce.Data;
using BrandClothingEcommerce.Models;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;

namespace BrandClothingEcommerce.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        // Поле и конструктор бд
        private readonly ApplicationDbContext _db;
        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        // Получаем коллекцию типов одежды
        public async Task<IEnumerable<TypeOfСlothing>> TypeOfСlothing()
        {
            return await _db.TypeOfСlothing.ToListAsync();
        }
        // Асинхронно возвращаем коллекцию объектов Product
        public async Task<IEnumerable<Product>> GetProduct(string sTerm = "", int typeOfСlothingId = 0)
        {
            // приводим sTerm к нижнему регистру, делается это для того,
            // чтобы сравнивать значение sTerm с ProductName в независимом от регистра виде.
            sTerm = sTerm.ToLower();

            // Запрос                    // С помощью оператора join соединяя таблицы Products и TypeOfСlothing
            IEnumerable<Product> products = await (from product in _db.Products
                                                   join typeOfСlothing in _db.TypeOfСlothing
                                                   on product.TypeOfСlothingId equals typeOfСlothing.Id
                                                   // Если в поисковой строке ничего нет то и доп. фильтра ввиде
                                                   // (product != null && product.ProductName.ToLower().StartsWith(sTerm)) - не будут
                                                   where string.IsNullOrWhiteSpace(sTerm) ||
                                                   // StartsWith(), чтобы проверить начало строки на соответствие
                                                   (product != null && product.ProductName.ToLower().StartsWith(sTerm))
                                                   // Новый объект Product, который будет содержать только определенные
                                                   // свойства из исходных таблиц Products и TypeOfClothing.
                                                   select new Product
                                                   {
                                                       Id = product.Id,
                                                       Image = product.Image,
                                                       ProductName = product.ProductName,
                                                       TypeOfСlothingId = product.TypeOfСlothingId,
                                                       Price = product.Price,
                                                       TypeName = typeOfСlothing.TypeName
                                                   }).ToListAsync();
            // Если в параметрах указали typeOfСlothingId > 0, тогда выполнется фильтрация по типу одежды
            if (typeOfСlothingId > 0)
            {
                products = products.Where(a => a.TypeOfСlothingId == typeOfСlothingId).ToList();
            }
            // Возвращаем отфильтрованную коллекцию products
            return products;
        }


        //public async Task<Product> GetProductById(int productId)
        //{
        //    return await _db.Products.FindAsync(productId);
        //}

        //public void DeleteProduct(Product product)
        //{
        //    _db.Products.Remove(product);
        //}

        //public void UpdateProduct(Product product)
        //{
        //    _db.Products.Update(product);
        //}
    }
}
