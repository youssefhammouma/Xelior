using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xelior.Models;

namespace Xelior.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExigenceItemsController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public ExigenceItemsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/ExigenceItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExigenceItem>>> GetExigenceItem()
        {
            return await _context.ExigenceItem.ToListAsync();
        }

        // GET: api/ExigenceItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExigenceItem>> GetExigenceItem(long id)
        {
            var exigenceItem = await _context.ExigenceItem.FindAsync(id);

            if (exigenceItem == null)
            {
                return NotFound();
            }

            return exigenceItem;
        }

        // PUT: api/ExigenceItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExigenceItem(long id, ExigenceItem exigenceItem)
        {
            if (id != exigenceItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(exigenceItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExigenceItemExists(id))
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

        // POST: api/ExigenceItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExigenceItem>> PostExigenceItem(ExigenceItem exigenceItem)
        {
            _context.ExigenceItem.Add(exigenceItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExigenceItem), new { id = exigenceItem.Id }, exigenceItem);
        }

        // DELETE: api/ExigenceItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExigenceItem(long id)
        {
            var exigenceItem = await _context.ExigenceItem.FindAsync(id);
            if (exigenceItem == null)
            {
                return NotFound();
            }

            _context.ExigenceItem.Remove(exigenceItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExigenceItemExists(long id)
        {
            return _context.ExigenceItem.Any(e => e.Id == id);
        }
    }
}
