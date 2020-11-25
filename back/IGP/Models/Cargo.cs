using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IGP.Models
{
  public class Cargo
  {
    [Key]
    public int CargoID { get; set; }
    [Required]
    public string Nombre { get; set; }
    public ICollection<Empleado> Empleados { get; set; }
  }
}