using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Controllers
{
    public class AddProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AddProfile profile)
        {
            AddProfileRepository repository = new AddProfileRepository();
            repository.AddRegisteredProfile(profile);
            return RedirectToAction("Index", "Home");
        }
    }
}
