namespace Slaughter_House.Models
{
    public class Admin :Audit
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
