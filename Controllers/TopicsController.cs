using System;
using System.Collections.Generic;
using System.Data;
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
    public class TopicsController : Controller
    {
        private readonly UCTprojecthubContext _context;

        public TopicsController(UCTprojecthubContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var uCTprojecthubContext = _context.Topics.Include(t => t.Theme);
            return View(await uCTprojecthubContext.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Topics == null)
            {
                return NotFound();
            }

            var topic = await _context.Topics
                .Include(t => t.Theme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }

        [Authorize(Roles = "Mentor")]
        public IActionResult Create()
        {
            ViewData["ThemeId"] = new SelectList(_context.Themes, "Id", "Description");
            return View();
        }

        [Authorize(Roles = "Mentor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,isChosen,DateCreated,DateUpdated,ThemeId,UserId")] Topic topic)
        {
            if (ModelState.IsValid)
            {
                topic.Id = Guid.NewGuid();
                _context.Add(topic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ThemeId"] = new SelectList(_context.Themes, "Id", "Description", topic.ThemeId);
            return View(topic);
        }

        [Authorize(Roles = "Mentor")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Topics == null)
            {
                return NotFound();
            }

            var topic = await _context.Topics.FindAsync(id);
            if (topic == null)
            {
                return NotFound();
            }
            ViewData["ThemeId"] = new SelectList(_context.Themes, "Id", "Description", topic.ThemeId);
            return View(topic);
        }

        [Authorize(Roles = "Mentor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Description,isChosen,DateCreated,DateUpdated,ThemeId,UserId")] Topic topic)
        {
            if (id != topic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(topic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopicExists(topic.Id))
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
            ViewData["ThemeId"] = new SelectList(_context.Themes, "Id", "Description", topic.ThemeId);
            return View(topic);
        }

        [Authorize(Roles = "Mentor")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Topics == null)
            {
                return NotFound();
            }

            var topic = await _context.Topics
                .Include(t => t.Theme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }

        [Authorize(Roles = "Mentor")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Topics == null)
            {
                return Problem("Entity set 'UCTprojecthubContext.Topics'  is null.");
            }
            var topic = await _context.Topics.FindAsync(id);
            if (topic != null)
            {
                _context.Topics.Remove(topic);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopicExists(Guid id)
        {
          return _context.Topics.Any(e => e.Id == id);
        }
    }
}
