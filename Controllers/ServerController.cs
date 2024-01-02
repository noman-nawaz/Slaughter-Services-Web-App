using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;
using Slaughter_House.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace Slaughter_House.Controllers
{
    public class ServerController : Controller
    {
        public IActionResult Index() { return View(); } 
    }
} 
