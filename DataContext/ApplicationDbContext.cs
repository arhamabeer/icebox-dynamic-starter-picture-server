
using icebox_dynamic_starter_picture_server.ModelBuilderExtenstion;

namespace icebox_dynamic_starter_picture_server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options) :base(options)
         {}

        public DbSet<Machine> Machines { get; set; }
        public DbSet<Images> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Images>().HasKey(x => x.ImageId);
            modelBuilder.Seed();
            modelBuilder.MachineSeed();
        }

    }

}
