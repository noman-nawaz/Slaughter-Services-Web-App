using Microsoft.AspNetCore.Mvc;

namespace Slaughter_House.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
