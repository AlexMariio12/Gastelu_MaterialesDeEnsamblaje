using Microsoft.AspNetCore.Mvc;

namespace MaterialesDeEnsamblaje.Controllers
{
    public class AplicacionesIndustrialesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
