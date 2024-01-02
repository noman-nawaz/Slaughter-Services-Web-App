using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Controllers
{
    public class RemoveButcherController : Controller
    {
        public IActionResult Index()
        {
            ButcherRepository book = new ButcherRepository();
            List<RegisteredButcher> butcher = book.BookButcher();
            return View(butcher);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            ButcherRepository remove = new ButcherRepository();
            remove.RemoveButcher(id);
            return RedirectToAction("RegisterButcher","Index");
        }

    }
}
