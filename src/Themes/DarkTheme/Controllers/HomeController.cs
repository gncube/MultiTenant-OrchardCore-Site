using Microsoft.AspNetCore.Mvc;

namespace DarkTheme.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
