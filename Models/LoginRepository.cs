using Microsoft.Identity.Client;

namespace Slaughter_House.Models
{
    public class LoginRepository
    {
        public bool Validate(Login user)
        {
            RegistrationDbContext cx = new RegistrationDbContext();
            List<RegisteredButcher> Users = cx.Registers.ToList();

            foreach (var usr in Users)
            {
                if (usr.Username == user.Username && usr.Password == user.Password)
                    return true;

            }
            return false;
            
        }

    }
}
