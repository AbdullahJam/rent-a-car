using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_Programlama.Data;
using Web_Programlama.Models;

namespace Web_Programlama.Controllers
{
    public class ArabasController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment; 

        public ArabasController(ApplicationDbContext context , IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Arabas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Araba.Include(a => a.Kategori);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Arabas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var araba = await _context.Araba
                .Include(a => a.Kategori)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (araba == null)
            {
                return NotFound();
            }

            return View(araba);
        }

        // GET: Arabas/Create
        public IActionResult Create()
        {
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "KategoriAd");
            return View();
        }

        // POST: Arabas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ArabaAd,KategoriId,FotografId,YilModulu,UretilenFirma,Vites,Yikit")] Araba araba)
        {
            if (ModelState.IsValid)
            {
                //************


                    //*************
                    _context.Add(araba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "KategoriAd", araba.KategoriId);
            return View(araba);
        }

        // GET: Arabas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var araba = await _context.Araba.FindAsync(id);
            if (araba == null)
            {
                return NotFound();
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", araba.KategoriId);
            return View(araba);
        }

        // POST: Arabas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ArabaAd,KategoriId,FotografId,YilModulu,UretilenFirma,Vites,Yikit")] Araba araba)
        {
            if (id != araba.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(araba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArabaExists(araba.Id))
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
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", araba.KategoriId);
            return View(araba);
        }

        // GET: Arabas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var araba = await _context.Araba
                .Include(a => a.Kategori)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (araba == null)
            {
                return NotFound();
            }

            return View(araba);
        }

        // POST: Arabas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var araba = await _context.Araba.FindAsync(id);
            _context.Araba.Remove(araba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArabaExists(int id)
        {
            return _context.Araba.Any(e => e.Id == id);
        }
    }
}
