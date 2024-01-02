using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Controllers
{
    public class ButcherInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
