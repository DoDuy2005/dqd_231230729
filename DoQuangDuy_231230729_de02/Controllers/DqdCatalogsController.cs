using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoQuangDuy_231230729_de02.Models;

namespace DoQuangDuy_231230729_de02.Controllers
{
    public class DqdCatalogsController : Controller
    {
        private readonly DoQuangDuy231230729De02Context _context;

        public DqdCatalogsController(DoQuangDuy231230729De02Context context)
        {
            _context = context;
        }

        // GET: DqdCatalogs
        public async Task<IActionResult> DqdIndex()
        {
            return View(await _context.DqdCatalogs.ToListAsync());
        }

        // GET: DqdCatalogs/Details/5
        public async Task<IActionResult> DqdDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dqdCatalog = await _context.DqdCatalogs
                .FirstOrDefaultAsync(m => m.DqdId == id);
            if (dqdCatalog == null)
            {
                return NotFound();
            }

            return View(dqdCatalog);
        }

        // GET: DqdCatalogs/Create
        public IActionResult DqdCreate()
        {
            return View();
        }

        // POST: DqdCatalogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DqdCreate([Bind("DqdId,DqdCateName,DqdCatePrice,DqdCateQty,DqdPicture,DqdCateActive")] DqdCatalog dqdCatalog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dqdCatalog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DqdIndex));
            }
            return View(dqdCatalog);
        }

        // GET: DqdCatalogs/Edit/5
        public async Task<IActionResult> DqdEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dqdCatalog = await _context.DqdCatalogs.FindAsync(id);
            if (dqdCatalog == null)
            {
                return NotFound();
            }
            return View(dqdCatalog);
        }

        // POST: DqdCatalogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DqdEdit(int id, [Bind("DqdId,DqdCateName,DqdCatePrice,DqdCateQty,DqdPicture,DqdCateActive")] DqdCatalog dqdCatalog)
        {
            if (id != dqdCatalog.DqdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dqdCatalog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DqdCatalogExists(dqdCatalog.DqdId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(DqdIndex));
            }
            return View(dqdCatalog);
        }

        // GET: DqdCatalogs/Delete/5
        public async Task<IActionResult> DqdDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dqdCatalog = await _context.DqdCatalogs
                .FirstOrDefaultAsync(m => m.DqdId == id);
            if (dqdCatalog == null)
            {
                return NotFound();
            }

            return View(dqdCatalog);
        }

        // POST: DqdCatalogs/Delete/5
        [HttpPost, ActionName("DqdDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DqdDeleteConfirmed(int id)
        {
            var dqdCatalog = await _context.DqdCatalogs.FindAsync(id);
            if (dqdCatalog != null)
            {
                _context.DqdCatalogs.Remove(dqdCatalog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DqdIndex));
        }

        private bool DqdCatalogExists(int id)
        {
            return _context.DqdCatalogs.Any(e => e.DqdId == id);
        }
    }
}
