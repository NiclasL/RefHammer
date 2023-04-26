using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RefHammer.Enums;
using RefHammer.Model;

namespace RefHammer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly dbContext _context;

        public GamesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGameItems()
        {
          if (_context.GameItems == null)
          {
              return NotFound();
          }
            return await _context.GameItems.ToListAsync();
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(Guid id)
        {
          if (_context.GameItems == null)
          {
              return NotFound();
          }
            var game = await _context.GameItems.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        // PUT: api/Games/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(Guid id, Game game)
        {
            if (id != game.id)
            {
                return BadRequest();
            }

            _context.Entry(game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
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

        // POST: api/Games
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Game>> PostGame(Game game)
        {
          if (_context.GameItems == null)
          {
              return Problem("Entity set 'dbContext.GameItems'  is null.");
          }
            _context.GameItems.Add(new Game
            {
                id = new Guid(),
                name = game.name,
                endDate = game.endDate,
                gameType = game.gameType,
                startDate = game.startDate
            }) ;
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGame", new { id = game.id }, game);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(Guid id)
        {
            if (_context.GameItems == null)
            {
                return NotFound();
            }
            var game = await _context.GameItems.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.GameItems.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameExists(Guid id)
        {
            return (_context.GameItems?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
