using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.persistance
{
    public class customDBContext : DbContext
    {

        public customDBContext(DbContextOptions<customDBContext>  options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CusPersona>()
                .ToTable("cus_persona", schema: "negocio");
        }

        public DbSet<CusPersona> Personas { get; set; }

    }
}
