using Microsoft.EntityFrameworkCore;

namespace karbantartas.Models
{
    public class KarbantartoContext : DbContext 
    {
        protected readonly IConfiguration Configuration;

        public KarbantartoContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("karbantartasE");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        

        public DbSet<Feladatok> Feladatok { get; set; } = null!;

        public DbSet<Karbantartasok> Karbantartasok { get; set; } = null!;

        public DbSet<Karbantartok> Karbantartok { get; set; } = null!;

        public DbSet<Anyagszukseglet> Anyagszukseglet { get;set; } = null!;




    }
}
