using Microsoft.AspNetCore.Mvc;

namespace MaterialesDeEnsamblaje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
