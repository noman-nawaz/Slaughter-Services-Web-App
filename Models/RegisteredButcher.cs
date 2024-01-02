using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Slaughter_House.Models
{
    public class RegisteredButcher :Audit
    {
        public RegisteredButcher()
        {

        }
        [Key]
        public int Register_Id { get; set; }

        [Required]
        [Display(Name = "Name*")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Phone No.*")]
        [Phone]
        public string? Phone { get; set; }

        [Required]
        [Display(Name = "City*")]
        public string? City { get; set; }


        [Required]
        [Display(Name = "UserName*")]
        public string? Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password*")]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password*")]
        [Compare("Password", ErrorMessage = "Passwords don't match. Enter again!")]
        public string? ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Experience in Years*")]
        public string? Experience { get; set; }

        [Required]
        [Display(Name = "You must accept out Terms & Conditions*")]
        public bool Liability { get; set; }

        public string? Medical { get; set; }

       

    }
}