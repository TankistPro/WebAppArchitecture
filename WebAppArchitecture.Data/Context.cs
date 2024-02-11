using Microsoft.EntityFrameworkCore;
using WebAppArchitecture.Data.Entityes;

namespace WebAppArchitecture.Data
{
    public class Context : DbContext
    {
        public DbSet<Directory> Directory { get; set; }
        public DbSet<Material> Material { get; set; }


        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAppArchitecture;Trusted_Connection=True;Integrated Security=True;");
        }
    }
}
