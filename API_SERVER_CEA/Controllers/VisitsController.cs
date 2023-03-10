using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_SERVER_CEA.Context;
using API_SERVER_CEA.Models;

namespace API_SERVER_CEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public VisitsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Visits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Visit>>> GetVisita()
        {
            return await _context.Visita.ToListAsync();
        }

        // GET: api/Visits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Visit>> GetVisit(int id)
        {
            var visit = await _context.Visita.FindAsync(id);

            if (visit == null)
            {
                return NotFound();
            }

            return visit;
        }

        // PUT: api/Visits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisit(int id, Visit visit)
        {
            if (id != visit.id)
            {
                return BadRequest();
            }

            _context.Entry(visit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitExists(id))
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

        // POST: api/Visits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Visit>> PostVisit(Visit visit)
        {
            _context.Visita.Add(visit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisit", new { id = visit.id }, visit);
        }

        // DELETE: api/Visits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisit(int id)
        {
            var visit = await _context.Visita.FindAsync(id);
            if (visit == null)
            {
                return NotFound();
            }

            _context.Visita.Remove(visit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VisitExists(int id)
        {
            return _context.Visita.Any(e => e.id == id);
        }
    }
}
