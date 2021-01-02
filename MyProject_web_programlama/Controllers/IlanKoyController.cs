using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyProject_web_programlama.Data;
using MyProject_web_programlama.Models;

namespace MyProject_web_programlama.Controllers
{
    public class IlanKoyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IlanKoyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IlanKoy
        public async Task<IActionResult> Index()
        {
            return View(await _context.IlanKoy.ToListAsync());
        }

        // GET: IlanKoy/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilanKoy = await _context.IlanKoy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ilanKoy == null)
            {
                return NotFound();
            }

            return View(ilanKoy);
        }

        // GET: IlanKoy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IlanKoy/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tarih,Fiyat")] IlanKoy ilanKoy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ilanKoy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ilanKoy);
        }

        // GET: IlanKoy/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilanKoy = await _context.IlanKoy.FindAsync(id);
            if (ilanKoy == null)
            {
                return NotFound();
            }
            return View(ilanKoy);
        }

        // POST: IlanKoy/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tarih,Fiyat")] IlanKoy ilanKoy)
        {
            if (id != ilanKoy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ilanKoy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IlanKoyExists(ilanKoy.Id))
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
            return View(ilanKoy);
        }

        // GET: IlanKoy/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilanKoy = await _context.IlanKoy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ilanKoy == null)
            {
                return NotFound();
            }

            return View(ilanKoy);
        }

        // POST: IlanKoy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ilanKoy = await _context.IlanKoy.FindAsync(id);
            _context.IlanKoy.Remove(ilanKoy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IlanKoyExists(int id)
        {
            return _context.IlanKoy.Any(e => e.Id == id);
        }
    }
}
