using Microsoft.AspNetCore.Mvc;

namespace baitapvenha.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            ViewBag.Message = "trang ch?";
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.Message = "ch�o bn";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "cx kh�ng c� j";
            return View();
        }
       
    }

}
