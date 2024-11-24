using Microsoft.AspNetCore.Mvc;

namespace MaterialesDeEnsamblaje.Controllers
{
    public class TiposMaterialesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
