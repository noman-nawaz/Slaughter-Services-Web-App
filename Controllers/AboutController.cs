using Microsoft.AspNetCore.Mvc;

namespace Slaughter_House.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
