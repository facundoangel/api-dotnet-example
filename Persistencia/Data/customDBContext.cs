using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia.Data
{


    public class CustomDBContext : IdentityDbContext<CusPersona, IdentityRole<int>, int>
    {

        public CustomDBContext(DbContextOptions<CustomDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);           
            modelBuilder.Entity<CusPersona>(entity => {
                entity.ToTable("cus_persona", schema: "negocio");
                entity.Property(e => e.Id).HasColumnName("persona");
            });
        }

        public DbSet<CusPersona> Personas { get; set; }

    }


}
