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

        public DbSet<UserProfile> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<UserProfile> students = new List<UserProfile>();
            UserProfile student = new UserProfile();
            student.Id = 1;
            student.Name = "Sajib";
            student.Age = 20;
            students.Add(student);

            student = new UserProfile();
            student.Id = 2;
            student.Name = "Mistry";
            student.Age = 30;
            students.Add(student);

            student = new UserProfile();
            student.Id = 3;
            student.Name = "Mike";
            student.Age = 40;
            students.Add(student);
            modelBuilder.Entity<UserProfile>().HasData(students);
        }
    }
}
