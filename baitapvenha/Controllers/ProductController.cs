using Microsoft.AspNetCore.Mvc;

namespace baitapvenha.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "chào bn";
            return View();
        }

        public IActionResult Detail()
        {
            ViewBag.Message = "hủm";
            return View();
        }
    }
}
