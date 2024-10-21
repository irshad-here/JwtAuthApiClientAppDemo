using AuthClient.App.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthClient.App.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var orders = new List<OrderViewModel>
            {
                new OrderViewModel{OrderId = 1, Product="Pen", Price = 2, Quantity = 1000},
                new OrderViewModel{ OrderId = 2, Product = "Paper", Price = 20, Quantity = 50},
                new OrderViewModel{ OrderId = 3, Product = "Printer", Price = 150, Quantity = 10}
            };

            return View(orders);
        }
    }
}
