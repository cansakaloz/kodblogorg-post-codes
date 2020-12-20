using Microsoft.EntityFrameworkCore;

namespace _20201220_aspnetcore_giris
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Username=ozcan;Password=okasal01;Database=asptutorial");
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}