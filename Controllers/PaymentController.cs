using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Payment payment)
        {
            PaymentRepository paymentRepository = new PaymentRepository();
            paymentRepository.AddPayment(payment);
            return RedirectToAction("index", "home");
        }
    }
}
