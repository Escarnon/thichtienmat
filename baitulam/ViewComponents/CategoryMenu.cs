using baitulam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace baitulam.ViewComponents
{
    public class CategoryMenu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<String>
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
            return View(categories);
        }
    }
}
