using System.Diagnostics;
using baitulam.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace baitulam.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Index()
        {
            var cooks = new List<Cook>
            {
                new Cook { Name = "noi1", Image = "/image/product/noi1.png" },
                new Cook { Name = "noi2", Image = "/image/product/noi2.jpg" },
                new Cook { Name = "noi3", Image = "/image/product/noi3.jpg" },
                new Cook { Name = "noi4", Image = "/image/product/noi4.jpg" },
                new Cook { Name = "noi5", Image = "/image/product/noi5.jpg" },

            };
            return View(cooks);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CategoryMenu()
        {
            var categories = new List<string>
            {
                "Áo sơ mi",
                "Áo phông", 
                "Túi xách", 
                "Đồng hồ",
                "Ví da", 
                "Tai nghe", 
                "Loa", 
                "Điện thoại", 
                "Laptop", 
                "Lò sưởi"
             };
            return PartialView("_CategoryMenu", categories);
        }


    }
}
