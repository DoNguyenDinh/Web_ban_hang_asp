using Ecommerces_asp.net.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.ViewComponents
{
    public class SupplierViewComponent:ViewComponent
    {
        private MarketContext _context;
        public SupplierViewComponent(MarketContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Suppliers.ToListAsync());
        }
    }
}
