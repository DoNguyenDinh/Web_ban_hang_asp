using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ecommerces_asp.net.Areas.Admin.Data;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerces_asp.net.Areas.Admin.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SupplierAPIController : ControllerBase
    {
        private readonly MarketContext _content;
        public SupplierAPIController(MarketContext context)
        {
            _content = context;
        }
        public async Task<ActionResult<IEnumerable<Category>>> GetSupplier()
        {
            return await _content.Categories.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<supplier>> GetSupplier(int id)
        {
            var supplier = await _content.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return supplier;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSup(int id, supplier sup)
        {
            if (id!=sup.Id)
            {
                return BadRequest();
            }
            _content.Entry(sup).State = EntityState.Modified;
            try
            {
                await _content.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<supplier>> PostSup(supplier sup)
        {
            _content.Suppliers.Add(sup);
            await _content.SaveChangesAsync();
            return CreatedAtAction("GetSupplier", new { id = sup.Id }, sup);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<supplier>> Delete(int id)
        {
            var sup = await _content.Suppliers.FindAsync(id);
            if (sup == null)
            {
                return NotFound();
            }
            _content.Suppliers.Remove(sup);
            await _content.SaveChangesAsync();
            return sup;
        }
        private bool SupplierExists(int id)
        {
            return _content.Suppliers.Any(e => e.Id == id);
        }
    }
}
