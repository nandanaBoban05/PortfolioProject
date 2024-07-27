using Microsoft.EntityFrameworkCore;
using PortfolioProject.Models;
namespace PortfolioProject.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) 
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
               new Project
               {
                   ProjectId = 1,
                   Name = "Eliassen Group",
                   Url = "http://project1.com",
                   StartDate = new DateOnly(2024, 2, 5),
                   EndDate = new DateOnly(2024, 6, 30)
               },
                new Project
                {
                    ProjectId = 2,
                    Name = "Project 2",
                    Url = "http://project2.com",
                    StartDate = new DateOnly(2024, 3, 1),
                    EndDate = new DateOnly(2024, 8, 15)
                },
                new Project
                {
                    ProjectId = 3,
                    Name = "Project 3",
                    Url = "http://project3.com",
                    StartDate = new DateOnly(2024, 4, 10),
                    EndDate = new DateOnly(2024, 9, 20)
                }
                );


        }

    }
}
