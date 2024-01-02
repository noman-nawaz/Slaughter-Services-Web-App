using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;
using System.Diagnostics;

namespace Slaughter_House.Controllers
{
	public class HomeController : Controller
	{

		public IActionResult Index()
		{
            string cookieKey = "first_visit_datetime";
            object data = "Welcome New User!";

            if (!HttpContext.Request.Cookies.ContainsKey(cookieKey))
            {
                HttpContext.Response.Cookies.Append(cookieKey, System.DateTime.Now.ToString());
                return View(data);
            }
            else
            {
                string? lastVisitedDatetime = HttpContext.Request.Cookies[cookieKey];
                data = $"Welcome Back | You visited last time at: {lastVisitedDatetime}";
                return View(data);
            }

        }

    }
}