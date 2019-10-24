using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrendLogProjekt.Data;
using TrendLogProjekt.Models;

namespace TrendLogProjekt.Controllers
{
    public class ChannelRootobjectsController : Controller
    {
        private readonly DataContext _context;

        public ChannelRootobjectsController(DataContext context)
        {
            _context = context;
        }

        // GET: ChannelRootobjects
        public async Task<IActionResult> Index()
        {
            return View(await _context.channels.ToListAsync());
        }

        // GET: ChannelRootobjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var channelRootobject = await _context.channels
                .FirstOrDefaultAsync(m => m.ChannelId == id);
            if (channelRootobject == null)
            {
                return NotFound();
            }

            return View(channelRootobject);
        }

        // GET: ChannelRootobjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChannelRootobjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChannelId")] ChannelRootobject channelRootobject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(channelRootobject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(channelRootobject);
        }

        // GET: ChannelRootobjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var channelRootobject = await _context.channels.FindAsync(id);
            if (channelRootobject == null)
            {
                return NotFound();
            }
            return View(channelRootobject);
        }

        // POST: ChannelRootobjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChannelId")] ChannelRootobject channelRootobject)
        {
            if (id != channelRootobject.ChannelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(channelRootobject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChannelRootobjectExists(channelRootobject.ChannelId))
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
            return View(channelRootobject);
        }

        // GET: ChannelRootobjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var channelRootobject = await _context.channels
                .FirstOrDefaultAsync(m => m.ChannelId == id);
            if (channelRootobject == null)
            {
                return NotFound();
            }

            return View(channelRootobject);
        }

        // POST: ChannelRootobjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var channelRootobject = await _context.channels.FindAsync(id);
            _context.channels.Remove(channelRootobject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChannelRootobjectExists(int id)
        {
            return _context.channels.Any(e => e.ChannelId == id);
        }
    }
}
