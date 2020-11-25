using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IGP.Models
{
  public class Empleado
  {
    [Key]
    public int EmpleadoID { get; set; }
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string Apellido { get; set; }
    [Required]
    public double DocIdentidad { get; set; }
    [Required]
    public int CargoID { get; set; }

    public Cargo Cargo { get; set; }

  }
}
