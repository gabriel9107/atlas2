using Atlas.Shared;
using Microsoft.EntityFrameworkCore;


namespace Atlas.API.Data
{
    public class DataContext : DbContext
    {
        private  DbContext _context;
        public DataContext(DbContextOptions<DataContext> options) :base (options){
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Cliente>().HasIndex(x => x.Cedula_RNC).IsUnique();
        }


        public DbSet<Country> countries { get; set; }
        public DbSet<Cliente> clientes { get; set; }

    }
}
