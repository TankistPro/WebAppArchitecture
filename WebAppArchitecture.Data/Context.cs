using Microsoft.EntityFrameworkCore;
using WebAppArchitecture.Data.Entityes;

namespace WebAppArchitecture.Data
{
    internal class Context : DbContext
    {
        public DbSet<Directory> Directory { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Material> Material { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAppArchitecture;Trusted_Connection=True;Integrated Security=True;");
        }
    }
}
