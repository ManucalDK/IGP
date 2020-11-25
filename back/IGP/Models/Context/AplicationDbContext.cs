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
      //Seed de la Base de datos
      //modelo de cargos
      modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = 1, Nombre = "Gerente" });
      modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = 2, Nombre = "Vendedor" });
      modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = 3, Nombre = "Coordinador" });
      modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = 4, Nombre = "SubGerente" });


      modelBuilder.Entity<Empleado>().HasData(new Empleado { EmpleadoID = 1, Nombre = "Manuel", Apellido = "Calambas", DocIdentidad = 1061732742, CargoID = 1 });
      modelBuilder.Entity<Empleado>().HasData(new Empleado { EmpleadoID = 2, Nombre = "Martha", Apellido = "Giraldo", DocIdentidad = 34319349, CargoID = 4 });
      modelBuilder.Entity<Empleado>().HasData(new Empleado { EmpleadoID = 3, Nombre = "Arturo", Apellido = "Bedoya", DocIdentidad = 1054765323, CargoID = 2 });
      modelBuilder.Entity<Empleado>().HasData(new Empleado { EmpleadoID = 4, Nombre = "Alejandra", Apellido = "Calambas", DocIdentidad = 34323432, CargoID = 3 });
    }

  }
}