using Microsoft.AspNetCore.Mvc;

namespace MaterialesDeEnsamblaje.Controllers
{
    public class TecnicasEnsamblajeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
