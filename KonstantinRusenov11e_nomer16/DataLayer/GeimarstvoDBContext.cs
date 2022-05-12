using BusinessLayer;
using Microsoft.EntityFrameworkCore;


namespace DataLayer
{
    public class GamingDbContext : DbContext
    {
        public GamingDbContext()
        {

        }

        public GamingDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(@"Server=127.0.0.1;Port=3306;Database=GeimarstvoDB;Uid=root;Pwd=MinecraF1");
            }
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

    }
}