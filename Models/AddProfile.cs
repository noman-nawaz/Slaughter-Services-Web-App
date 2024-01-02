using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slaughter_House.Models
{
    public class AddProfile : Audit
    {

        public AddProfile()
        {

        }
        [Key]
        public int Profile_Id { get; set; }

        [Required]
        [Display(Name = "Username*")]
        public string? Username { get; set; }

        [Required]
        [Display(Name = "Animal you slaughter*")]
        public string? Animal { get; set; }

        [Required]
        [Display(Name = "Price*")]
        public int Price { get; set; }

        [Display(Name = "Available Day for Qurbani?")]
        [Required]
        public string? Day { get; set; }
       
       
    }
}
