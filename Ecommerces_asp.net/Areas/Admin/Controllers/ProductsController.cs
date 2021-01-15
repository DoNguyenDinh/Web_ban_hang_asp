using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerces_asp.net.Areas.Admin.Data;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Ecommerces_asp.net.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly MarketContext _context;

        public ProductsController(MarketContext context)
        {
            _context = context;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            var marketContext = _context.Products.Include(p => p.Category).Include(p => p.Supplier);
            return View(await marketContext.ToListAsync());
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            //ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            //ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id");
            ViewBag.cate = _context.Categories;
            ViewBag.sup = _context.Suppliers;
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,color,UnitBrief,UnitPrice,Image,ProductDate,Available,Description,CategoryId,SupplierId,Quantity,Discount,Special,Latest,Views")] Product product,IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Admin/images", product.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                product.Image = product.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", product.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", product.SupplierId);
            return View(product);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            //ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", product.CategoryId);
            //ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", product.SupplierId);
            ViewBag.cate = _context.Categories;
            ViewBag.sup = _context.Suppliers;
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,color,UnitBrief,UnitPrice,Image,ProductDate,Available,Description,CategoryId,SupplierId,Quantity,Discount,Special,Latest,Views")] Product product,IFormFile ful)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ful != null)
                    {
                        String IMG = product.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Admin/images", product.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        product.Image = IMG;
                        return RedirectToAction(nameof(Index));

                    }
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", product.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Id", product.SupplierId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
