using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace UpdatedWebBCE.Controllers
{
    // Этот контролллер отвечает за нажатие по элементам в хедер и футер
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
