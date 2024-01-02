using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Admin login)
        {
            
            if (login.Username == "Noman" && login.Password=="123")
            {

                return RedirectToAction("Index", "RemoveButcher");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }


}
