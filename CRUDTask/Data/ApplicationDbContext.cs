using CRUDTask.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUDTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=CRUDTask;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}