using System.Collections.Generic;
using System.Threading.Tasks;
using IGP.Models;
using IGP.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IGP.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class EmpleadoController : ControllerBase
  {
    private readonly AplicationDbContext _context;

    public EmpleadoController(AplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Empleado>>> GetEmpleados()
    {
      return Ok(await _context.Empleado.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Empleado>> GetEmpleado(int id)
    {

      Empleado empleado = await _context.Empleado.FindAsync(id);
      if (empleado == null)
        return NotFound();
      else
        return Ok(empleado);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ActionResult<List<Empleado>>>> UpdateEmpleado(int id, Empleado empleado)
    {
      if (id != empleado.EmpleadoID)
        return BadRequest();
      else
      {
        _context.Entry(empleado).State = EntityState.Modified;
        _context.Entry(empleado).Property(x => x.DocIdentidad).IsModified = false;
        try
        {
          await _context.SaveChangesAsync();
          return CreatedAtAction("GetEmpleado", new { id = empleado.EmpleadoID }, empleado);
        }
        catch (DbUpdateConcurrencyException)
        {
          return BadRequest();
        }
      }
    }

    [HttpPost]
    public async Task<ActionResult<Empleado>> AddEmpleado(Empleado empleado)
    {
      _context.Empleado.Add(empleado);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetEmpleados", new { id = empleado.EmpleadoID }, empleado);
    }
  }
}