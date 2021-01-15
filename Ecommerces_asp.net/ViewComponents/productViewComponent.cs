using Ecommerces_asp.net.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.ViewComponents
{
    public class productViewComponent:ViewComponent
    {
        private MarketContext _context;
        public productViewComponent(MarketContext context)
        {
            _context=context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Products.ToListAsync());
        }
    }
}
