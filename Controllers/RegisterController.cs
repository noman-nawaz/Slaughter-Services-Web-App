
using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisteredButcher reg)
        {
            ButcherRepository br = new ButcherRepository();
            if (ModelState.IsValid)
            {
                br.AddButcher(reg);
                return View("Submit",reg);
            }
            else
            {
                return View("Index");
            }
        }

       
    }
    
}


