using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CalculoMassa.Model;

namespace CalculoMassa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassasController : ControllerBase
    {
        private readonly CaculoMassContext _context;

        public MassasController(CaculoMassContext context)
        {
            _context = context;
        }

        // GET: api/Massas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Massa>>> GetMassas()
        {
            return await _context.Massas.ToListAsync();
        }

        // GET: api/Massas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Massa>> GetMassa(int id)
        {
            var massa = await _context.Massas.FindAsync(id);

            if (massa == null)
            {
                return NotFound();
            }

            return massa;
        }

        // PUT: api/Massas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMassa(int id, Massa massa)
        {
            if (id != massa.Id)
            {
                return BadRequest();
            }

            _context.Entry(massa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MassaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Massas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Massa>> PostMassa(Massa massa)
        {
            massa.Peso = massa.Densidade * massa.VolumeTotal * 9.81;
            _context.Massas.Add(massa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMassa), new { id = massa.Id }, massa);
        }

        // DELETE: api/Massas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Massa>> DeleteMassa(int id)
        {
            var massa = await _context.Massas.FindAsync(id);
            if (massa == null)
            {
                return NotFound();
            }

            _context.Massas.Remove(massa);
            await _context.SaveChangesAsync();

            return massa;
        }

        private bool MassaExists(int id)
        {
            return _context.Massas.Any(e => e.Id == id);
        }
    }
}
