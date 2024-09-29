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
            List<Account> accounts = new List<Account>();
            UserProfile user;
            Account account = new Account();
            AccountGenerator accountGenerator;

            for (int i = 0; i < 10; i++)
            {
                user = new UserProfile();
                user = ProfleGenerator.GetNextAccount();
                user.Id = i + 1;
                userProfiles.Add(user);

                accountGenerator = new AccountGenerator(user);
                account = accountGenerator.GenerateAccount();
                accounts.Add(account);
            }

            modelBuilder.Entity<UserProfile>().HasData(userProfiles);
            modelBuilder.Entity<Account>().HasData(accounts);
        }
    }
}
