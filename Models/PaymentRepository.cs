namespace Slaughter_House.Models
{
    public class PaymentRepository
    {
        public void AddPayment(Payment p)
        {
            RegistrationDbContext cx= new RegistrationDbContext();
            cx.Payment.Add(p);
            cx.SaveChanges();
        }
    }
}
