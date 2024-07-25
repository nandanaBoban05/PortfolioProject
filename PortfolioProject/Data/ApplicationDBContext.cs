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
    }
}
