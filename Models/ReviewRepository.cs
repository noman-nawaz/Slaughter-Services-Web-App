namespace Slaughter_House.Models
{
    public class ReviewRepository
    {
        public void AddReview(Review review)
        {
            RegistrationDbContext cx = new RegistrationDbContext();
            cx.Add(review);
            cx.SaveChanges();
        }

        public List<Review> GetAllReviews()
        {
            RegistrationDbContext cx = new RegistrationDbContext();
            var Users = cx.Reviews.ToList();
            return Users;
        }
    }
}
