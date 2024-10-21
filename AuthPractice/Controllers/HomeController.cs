using Microsoft.AspNetCore.Mvc;

namespace AuthPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
