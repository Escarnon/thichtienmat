using Microsoft.AspNetCore.Mvc;
using baitulam.Models;
using System.Collections.Generic;
using baitulam.Models;

namespace DemoLab.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var hotcooks = new List<Cook>
            {
                new Cook { Name = "Nồi cơm điện cao tần Nagakawa HOT1", Image = "/image/product/noi1.png" },
                new Cook { Name = "Nồi cơm điện cao tần Nagakawa HOT2", Image = "/image/product/noi1.png" }
            };
            return View(hotcooks);
        }
    }
}
