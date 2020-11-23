using Microsoft.EntityFrameworkCore;

namespace IGP.Models.Context
{
  public class AplicationDbContext : DbContext
  {
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Empleado> Empleado { get; set; }
    public DbSet<Cargo> Cargo { get; set; }

    public DbSet<Auth> Auth { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Empleado>(empleado =>
     {
       empleado.HasKey(s => s.Id);
       empleado.Property(s => s.Id).ValueGeneratedOnAdd();
       empleado.Property(s => s.Nombre).IsRequired();
       empleado.Property(s => s.Apellido).IsRequired();
       empleado.Property(s => s.DocIdentidad).IsRequired();
       empleado.HasOne(s => s.cargo);
     });

      modelBuilder.Entity<Cargo>(cargo =>
      {
        cargo.HasKey(t => t.Id);
        cargo.Property(t => t.Id).ValueGeneratedOnAdd();
        cargo.Property(t => t.Nombre).IsRequired();
      });

      modelBuilder.Entity<Auth>(auth =>
     {
       auth.HasKey(t => t.Id);
       auth.Property(t => t.UserName).IsRequired();
       auth.Property(t => t.Pass).IsRequired();
     });
    }
  }
}