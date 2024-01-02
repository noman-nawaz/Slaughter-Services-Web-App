using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;
using System.Web;

namespace Slaughter_House.Controllers
{
	public class LoginController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Index(Login login)
        {
            LoginRepository _loginRepository = new LoginRepository();
            if (_loginRepository.Validate(login))
            {

                return RedirectToAction("Index","ButcherInfo");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}
