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

        public DbSet<Account> Accounts { get; set; }


        public DbSet<UserHistory> UserHistories { get; set; }


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
            user.Password = "Sajib123";
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


            List<Account> accounts = new List<Account>
            {
                new Account(1, "John", "Doe", "john.doe@email.com", 25, 1000, "1 Street Suburb"),
                new Account(2, "Jane", "Doe", "jane.doe@email.com", 30, 2000, "2 Street Suburb"),
                new Account(3, "Mike", "Smith", "mike.smith@email.com", 35, 3000, "3 Street Suburb")

            };

            modelBuilder.Entity<Account>().HasData(accounts);


        }
    }
}
