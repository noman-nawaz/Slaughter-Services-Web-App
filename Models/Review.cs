using System.ComponentModel.DataAnnotations;
namespace Slaughter_House.Models
{
    public class Review: Audit
    {
        [Key]
        public int Review_Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
    }
}
