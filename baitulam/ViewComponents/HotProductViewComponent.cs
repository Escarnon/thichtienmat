using Microsoft.AspNetCore.Mvc;
using baitulam.Models;
using System.Collections.Generic;

namespace baitulam.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var hotcooks = new List<Cook>
            {
                new Cook { Name = "Nồi cơm điện cao tần Nagakawa HOT1", Image = "/image/product/noi3.jpg" },
                new Cook { Name = "Nồi cơm điện cao tần Nagakawa HOT2", Image = "/image/product/noi4.jpg" }
            };
            return View(hotcooks);
        }
    }
}
