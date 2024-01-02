using Microsoft.EntityFrameworkCore;
using System;
using Slaughter_House.Models;



namespace Slaughter_House.Models
{
    public class RegistrationDbContext: DbContext
    {
        public virtual DbSet<RegisteredButcher> Registers { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<AddProfile> AddProfiles { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ButcherUpdatedDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public override int SaveChanges()
        {

            var changeTracker = this.ChangeTracker;

            foreach (var entry in changeTracker.Entries())
            {
                if (entry.State.Equals(EntityState.Added))
                {
                    foreach (var item in entry.Members)
                    {
                        if (item.Metadata.Name.Equals("CreatedAt"))
                        {
                            item.CurrentValue = DateTime.Now;
                        }
                    }

                }
                else if (entry.State.Equals(EntityState.Modified))
                {
                    foreach (var item in entry.Members)
                    {
                        if (item.Metadata.Name.Equals("ModifiedAt"))
                        {
                            item.CurrentValue = DateTime.Now;
                        }
                    }
                }
            }

            return base.SaveChanges();
        }
    }

}

