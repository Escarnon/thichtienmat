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
                new Cook { Name = "Nồi cơm điện cao tần Nagakawa HOT1", Image = "noi3.jpg" },
                new Cook { Name = "Nồi cơm điện cao tần Nagakawa HOT2", Image = "noi4.jpg" }
            };
            return View(hotcooks);
        }
    }
}
