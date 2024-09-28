using DataTierWebServer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataTierWebServer.Data
{
    public class DBManager : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Bank.db;");
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<UserProfile> userProfiles = new List<UserProfile>();
            UserProfile user = new UserProfile();
            user.Id = 1;
            user.Name = "Sajib";
            user.Email = "Sajib@email.com";
            user.Address = "1 Street Suburb";
            user.PhoneNumber = 1234567;
            user.ProfilePictureUrl = "SomeImage";
            user.Password = "Sajib123" ;
            userProfiles.Add(user);

            user = new UserProfile();
            user.Id = 2;
            user.Name = "Mistry";
            user.Email = "Mistry@email.com";
            user.Address = "2 Street Suburb";
            user.PhoneNumber = 2345678;
            user.ProfilePictureUrl = "SomeImage";
            user.Password = "Mistry123";
            userProfiles.Add(user);

            user = new UserProfile();
            user.Id = 3;
            user.Name = "Mike";
            user.Email = "Mike@email.com";
            user.Address = "3 Street Suburb";
            user.PhoneNumber = 3456789;
            user.ProfilePictureUrl = "SomeImage";
            user.Password = "Mike123" ;
            userProfiles.Add(user);


            modelBuilder.Entity<UserProfile>().HasData(userProfiles);
        }
    }
}
