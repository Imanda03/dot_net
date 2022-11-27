using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_WebApplication;
using MVC_WebApplication.Data;

namespace MVC_WebApplication.Controllers
{
    public class PlayerController : Controller
    {
        private readonly MVC_WebApplicationContext _context;

        public PlayerController(MVC_WebApplicationContext context)
        {
            _context = context;
        }

        // GET: Player
        public async Task<IActionResult> Index()
        {
              return View(await _context.Players.ToListAsync());
        }

        // GET: Player/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var players = await _context.Players
                .FirstOrDefaultAsync(m => m.Id == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // GET: Player/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Position,JNo,CId")] Players players)
        {
            if (ModelState.IsValid)
            {
                _context.Add(players);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(players);
        }

        // GET: Player/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var players = await _context.Players.FindAsync(id);
            if (players == null)
            {
                return NotFound();
            }
            return View(players);
        }

        // POST: Player/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Position,JNo,CId")] Players players)
        {
            if (id != players.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(players);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayersExists(players.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(players);
        }

        // GET: Player/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var players = await _context.Players
                .FirstOrDefaultAsync(m => m.Id == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Players == null)
            {
                return Problem("Entity set 'MVC_WebApplicationContext.Players'  is null.");
            }
            var players = await _context.Players.FindAsync(id);
            if (players != null)
            {
                _context.Players.Remove(players);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayersExists(int id)
        {
          return _context.Players.Any(e => e.Id == id);
        }
    }
}
