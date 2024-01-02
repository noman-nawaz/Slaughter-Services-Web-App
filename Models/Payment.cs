using System.ComponentModel.DataAnnotations;
namespace Slaughter_House.Models
{
    public class Payment : Audit
    {
        [Key]
        public int Payment_Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNo { get; set; }
        public string? PaymentMethod { get; set; }
        public decimal TotalPayableAmount { get; set; }
        public string? PaymentScreenshot { get; set; }
    }
}
