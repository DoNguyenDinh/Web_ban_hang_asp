using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerces_asp.net.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Ecommerces_asp.net.ViewComponents
{
    public class NewProductViewComponent:ViewComponent
    {
        private MarketContext _context;
        public NewProductViewComponent(MarketContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newpro = await _context.Products.Where(s => s.Latest == true).Take(4).ToListAsync();
            return View(newpro);
        }
    }
}
