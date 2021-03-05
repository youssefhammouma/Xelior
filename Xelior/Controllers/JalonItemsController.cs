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
    public class JalonItemsController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public JalonItemsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/JalonItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JalonItem>>> GetJalonItem()
        {
            return await _context.JalonItem.ToListAsync();
        }

        // GET: api/JalonItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JalonItem>> GetJalonItem(long id)
        {
            var jalonItem = await _context.JalonItem.FindAsync(id);

            if (jalonItem == null)
            {
                return NotFound();
            }

            return jalonItem;
        }

        // PUT: api/JalonItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJalonItem(long id, JalonItem jalonItem)
        {
            if (id != jalonItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(jalonItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JalonItemExists(id))
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

        // POST: api/JalonItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JalonItem>> PostJalonItem(JalonItem jalonItem)
        {
            _context.JalonItem.Add(jalonItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetJalonItem), new { id = jalonItem.Id }, jalonItem);
        }

        // DELETE: api/JalonItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJalonItem(long id)
        {
            var jalonItem = await _context.JalonItem.FindAsync(id);
            if (jalonItem == null)
            {
                return NotFound();
            }

            _context.JalonItem.Remove(jalonItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JalonItemExists(long id)
        {
            return _context.JalonItem.Any(e => e.Id == id);
        }
    }
}
