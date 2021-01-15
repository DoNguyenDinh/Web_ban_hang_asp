using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ecommerces_asp.net.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Ecommerces_asp.net.Areas.Admin.Models;
namespace Ecommerces_asp.net.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private MarketContext _context;
        public CategoryViewComponent(MarketContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Categories.ToListAsync());
        }
    }
}
