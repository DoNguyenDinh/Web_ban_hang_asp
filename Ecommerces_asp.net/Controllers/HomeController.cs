using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerces_asp.net.Areas.Admin.Data;
using PagedList.Core;


namespace Ecommerces_asp.net.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly MarketContext _context;
        public HomeController(MarketContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            
            ViewBag.pro = _context.Products.Where(m => m.Latest==true);
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.Product = _context.Products.Where(s=>s.Available==true);
            return View();
            
        }
        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Search(string search)
        {
            ViewData["GetDetails"] = search;
            var model = from m in _context.Products select m;
            if (!String.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.Name.Contains(search));
            }
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            return View("Index2",await model.ToListAsync());

            
        }
       
        public async Task<IActionResult> prouduct3(string Search)
        {
            var model = from m in _context.Products select m;
            if (!String.IsNullOrEmpty(Search))
            {
                model = model.Where(s => s.Name.Contains(Search));
            }
            return View(await model.ToListAsync());
        }
      
        public IActionResult about()
        {
            ViewBag.pro = _context.Products.Where(m => m.Discount != 0);
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.Product = _context.Products;
            return View();
        }
       
        public IActionResult contact()
        {
            ViewBag.pro = _context.Products.Where(m => m.Discount != 0);
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.Product = _context.Products;
            return View();
        }
        public IActionResult Offer()
        {
            return View();
        }
        public IActionResult product(Category cate)
        {
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.cate = _context.Categories;
            var product = _context.Products.Where(m => m.CategoryId == cate.Id);
            return View(product);
        }
        public IActionResult _Menu()
        {
            ViewBag.pro = _context.Products.Where(m => m.Discount != 0);
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.Product = _context.Products;
            return View();
        }
        public IActionResult product2(supplier sup)
        {
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.sup = _context.Suppliers;
            var supplier = _context.Products.Where(m => m.Supplier.Id == sup.Id);
            return View(supplier);
        }
      
        public IActionResult detail(int id,Category cate)
        {
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            var sanpham = _context.Products.Where(m => m.Id == id);
            ViewBag.pro = _context.Products.Where(m => m.Discount!=0).Take(4);
            return View(sanpham);
        }
        
    }
}
