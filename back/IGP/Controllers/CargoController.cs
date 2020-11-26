using System.Collections.Generic;
using System.Threading.Tasks;
using IGP.Models;
using IGP.Models.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IGP.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CargoController : ControllerBase
  {
    private readonly AplicationDbContext _context;

    public CargoController(AplicationDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    // [Authorize]
    public async Task<ActionResult<List<Cargo>>> GetCargos()
    {
      return await _context.Cargo.ToListAsync();
    }

    [HttpGet("{id}")]
    // [Authorize]
    public async Task<ActionResult<Cargo>> GetCargo(int id)
    {

      Cargo cargo = await _context.Cargo.FindAsync(id);
      if (cargo == null)
        return NotFound();
      else
        return Ok(cargo);
    }

    [HttpPut("{id}")]
    // [Authorize]
    public async Task<ActionResult<ActionResult<List<Cargo>>>> UpdateCargo(int id, Cargo cargo)
    {
      if (id != cargo.CargoID)
        return BadRequest();
      else
      {
        _context.Entry(cargo).State = EntityState.Modified;
 
        try
        {
          await _context.SaveChangesAsync();
          return CreatedAtAction("GetCargos", new { id = cargo.CargoID }, cargo);
        }
        catch (DbUpdateConcurrencyException)
        {
          return BadRequest();
        }
      }
    }

    [HttpPost]
    // [Authorize]
    public async Task<ActionResult<Cargo>> AddCargo(Cargo cargo)
    {
      _context.Cargo.Add(cargo);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetCargo", new { id = cargo.CargoID }, cargo);
    }
  }
}