using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UCTprojecthub.Data;
using UCTprojecthub.Models;

namespace UCTprojecthub.Controllers
{
    public class ThemesController : Controller
    {
        private readonly UCTprojecthubContext _context;

        public ThemesController(UCTprojecthubContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return View(await _context.Themes.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Themes == null)
            {
                return NotFound();
            }

            var theme = await _context.Themes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theme == null)
            {
                return NotFound();
            }

            return View(theme);
        }
        [Authorize(Roles ="Mentor")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Mentor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,DateCreated,DateUpdated,StudentCount,UserId")] Theme theme)
        {
            if (ModelState.IsValid)
            {
                theme.Id = Guid.NewGuid();
                _context.Add(theme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theme);
        }

        [Authorize(Roles = "Mentor")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Themes == null)
            {
                return NotFound();
            }

            var theme = await _context.Themes.FindAsync(id);
            if (theme == null)
            {
                return NotFound();
            }
            return View(theme);
        }

        [Authorize(Roles = "Mentor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Description,DateCreated,DateUpdated,StudentCount,UserId")] Theme theme)
        {
            if (id != theme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThemeExists(theme.Id))
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
            return View(theme);
        }

        [Authorize(Roles = "Mentor")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Themes == null)
            {
                return NotFound();
            }

            var theme = await _context.Themes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theme == null)
            {
                return NotFound();
            }

            return View(theme);
        }
        [Authorize(Roles = "Mentor")]

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Themes == null)
            {
                return Problem("Entity set 'UCTprojecthubContext.Themes'  is null.");
            }
            var theme = await _context.Themes.FindAsync(id);
            if (theme != null)
            {
                _context.Themes.Remove(theme);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThemeExists(Guid id)
        {
          return _context.Themes.Any(e => e.Id == id);
        }
    }
}
