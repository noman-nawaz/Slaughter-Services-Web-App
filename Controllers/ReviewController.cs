using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Review review)
        {
            ReviewRepository reviewRepository = new ReviewRepository();
            reviewRepository.AddReview(review);
            return RedirectToAction("Index","Home");
        }


    }

}
