using Microsoft.AspNetCore.Mvc;

namespace H2H.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
