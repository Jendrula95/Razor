using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System.Diagnostics;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 100,
            Name = "Kajak",
            Description = "Łódka jednoosobowa",
            Price = 275M
        };




        public IActionResult Index()
        {
            return View(myProduct);
        }
       
        public ActionResult DemoExpression() 
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExspressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;
            return View(myProduct);
        }
        public ActionResult DemoArray()
        {
            Product [] array =
              {
                  new Product {Name = "Kajak",Price = 275M },
                  new Product {Name = "Kamizelka ratunkowa",Price = 48.95M },
                  new Product {Name = "Piłka nożna",Price = 19.50M },
                  new Product {Name = "Flaga narożna",Price = 34.95M }
              };
            return View(array);
            
        }
    }
}