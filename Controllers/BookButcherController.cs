using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Controllers
{
	public class BookButcherController : Controller
	{
		public IActionResult Index()
		{
			ButcherRepository book = new ButcherRepository();
			List<RegisteredButcher> butcher = book.BookButcher();
			return View(butcher);
		}
	}
}
