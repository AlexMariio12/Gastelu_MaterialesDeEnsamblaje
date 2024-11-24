using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaterialesDeEnsamblaje.Controllers
{
    public class IntroduccionController : Controller
    {
        // GET: IntroduccionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: IntroduccionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IntroduccionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IntroduccionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IntroduccionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IntroduccionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IntroduccionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IntroduccionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
