using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace IGP.Models
{
  public class Cargo
  {

    public int Id { get; set; }

    public string Nombre { get; set; }
  }
}