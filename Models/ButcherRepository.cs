using Microsoft.EntityFrameworkCore;

namespace Slaughter_House.Models
{
    public class ButcherRepository
    {
       
        public void AddButcher(RegisteredButcher butcher)
        {
            RegistrationDbContext cx= new RegistrationDbContext();
            cx.Add(butcher);
            cx.SaveChanges();
        }

        public bool Validate(string? username)
        {
            RegistrationDbContext cx = new RegistrationDbContext();
            List<RegisteredButcher> Users = cx.Registers.ToList();

            foreach (var usr in Users)
            {
                if (usr.Username == username)
                    return true;
            }
         

            return false;
        }

        public List<RegisteredButcher> BookButcher()
        {
			RegistrationDbContext cx = new RegistrationDbContext();
			List<RegisteredButcher> Users = cx.Registers.ToList();
            return Users;
		}

        public void RemoveButcher(int id) 
        {
            RegistrationDbContext cx = new RegistrationDbContext();
            RegisteredButcher registeredButcher = new RegisteredButcher();
            registeredButcher=cx.Registers.Find(id);

            cx.Registers.Remove(registeredButcher);
        }
	}
}
