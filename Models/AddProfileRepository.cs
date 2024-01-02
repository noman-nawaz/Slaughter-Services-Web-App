namespace Slaughter_House.Models
{
    public class AddProfileRepository
    {
        public void AddRegisteredProfile(AddProfile profile)
        {
            RegistrationDbContext cx = new RegistrationDbContext();
            cx.AddProfiles.Add(profile);
            cx.SaveChanges();

        }
    }
}
