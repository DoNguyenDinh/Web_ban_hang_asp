using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerces_asp.net.Areas.Admin.Data;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerces_asp.net.Areas.Admin.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderAPIController : ControllerBase
    {
        private readonly MarketContext _content;
        public OrderAPIController(MarketContext context)
        {
            _content = context;
        }
        public async Task<ActionResult<IEnumerable<Order>>> GetSupplier()
        {
            return await _content.Orders.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetSupplier(int id)
        {
            var supplier = await _content.Orders.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return supplier;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSup(int id, Order sup)
        {
            if (id != sup.Id)
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
        public async Task<ActionResult<Order>> PostSup(Order sup)
        {
            _content.Orders.Add(sup);
            await _content.SaveChangesAsync();
            return CreatedAtAction("GetSupplier", new { id = sup.Id }, sup);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> Delete(int id)
        {
            var sup = await _content.Orders.FindAsync(id);
            if (sup == null)
            {
                return NotFound();
            }
            _content.Orders.Remove(sup);
            await _content.SaveChangesAsync();
            return sup;
        }
        private bool SupplierExists(int id)
        {
            return _content.Orders.Any(e => e.Id == id);
        }
    }
}
