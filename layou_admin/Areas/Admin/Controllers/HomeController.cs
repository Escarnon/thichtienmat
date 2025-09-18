using Microsoft.AspNetCore.Mvc;

namespace layou_admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Dashboard";
            // Truyền dữ liệu động tương tự như JSP EL:
            ViewData["countUsers"] = 1;
            ViewData["countProducts"] = 2;
            ViewData["countOrders"] = 3;
            ViewData["LoggedInUser"] = "bac-231230717"; // Tên người dùng đăng nhập
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
    }
}
    