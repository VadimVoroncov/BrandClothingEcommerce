using BrandClothingEcommerce.Models;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BrandClothingEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;

        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        public async Task<IActionResult> Index(string sterm = "", int typeOfСlothingId = 0)
        {
            IEnumerable<Product> products = await _homeRepository.GetProduct(sterm, typeOfСlothingId);
            IEnumerable<TypeOfСlothing> typeOfСlothings = await _homeRepository.TypeOfСlothing();
            ProductDisplayModel bookModel = new ProductDisplayModel
            {
                TypeOfСlothing = typeOfСlothings,
                Products = products,
                STerm = sterm,
                TypeOfСlothingId = typeOfСlothingId
            };

            return View(bookModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> AdminIndex(string sterm = "", int typeOfСlothingId = 0)
        //{
        //    IEnumerable<Product> products = await _homeRepository.GetProduct(sterm, typeOfСlothingId);
        //    IEnumerable<TypeOfСlothing> typeOfСlothings = await _homeRepository.TypeOfСlothing();
        //    ProductDisplayModel bookModel = new ProductDisplayModel
        //    {
        //        TypeOfСlothing = typeOfСlothings,
        //        Products = products,
        //        STerm = sterm,
        //        TypeOfСlothingId = typeOfСlothingId
        //    };

        //    return View(bookModel);
        //}

        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> DeleteProduct(int productId)
        //{
        //    Product product = await _homeRepository.GetProductById(productId);
        //    if (product != null)
        //    {
        //        _homeRepository.DeleteProduct(product);
        //        await _homeRepository.SaveChanges();
        //        return Ok();
        //    }

        //    return BadRequest("Product not found.");
        //}

        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> MarkProductOutOfStock(int productId)
        //{
        //    Product product = await _homeRepository.GetProductById(productId);
        //    if (product != null)
        //    {
        //        product.ProductStatus = ProductStatus.OutOfStock;
        //        _homeRepository.UpdateProduct(product);
        //        await _homeRepository.SaveChanges();
        //        return Ok();
        //    }

        //    return BadRequest("Product not found.");
        //}
    }
}