using Microsoft.AspNetCore.Mvc;
using Slaughter_House.Models;

namespace Slaughter_House.Components
{
    [ViewComponent]
    public class ReviewViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            ReviewRepository repository = new ReviewRepository();
            return View(repository.GetAllReviews());
        }
    }

}
