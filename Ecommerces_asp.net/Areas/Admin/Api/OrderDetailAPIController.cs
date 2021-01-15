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
    public class OrderDetailAPIController : ControllerBase
    {
        private readonly MarketContext _content;
        public OrderDetailAPIController(MarketContext context)
        {
            _content = context;
        }
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetCus()
        {
            return await _content.OrderDetails.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetail>> GetCus(int id)
        {
            var cus = await _content.OrderDetails.FindAsync(id);
            if (cus == null)
            {
                return NotFound();
            }
            return cus;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCus(int id, OrderDetail cus)
        {
            if (id != cus.Id)
            {
                return BadRequest();
            }
            _content.Entry(cus).State = EntityState.Modified;
            try
            {
                await _content.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustommmerExists(id))
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
        public async Task<ActionResult<OrderDetail>> PostCus(OrderDetail cus)
        {
            _content.OrderDetails.Add(cus);
            await _content.SaveChangesAsync();
            return CreatedAtAction("GetCus", new { id = cus.Id }, cus);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderDetail>> Delete(int id)
        {
            var cus = await _content.OrderDetails.FindAsync(id);
            if (cus == null)
            {
                return NotFound();
            }
            _content.OrderDetails.Remove(cus);
            await _content.SaveChangesAsync();
            return cus;
        }
        private bool CustommmerExists(int id)
        {
            return _content.OrderDetails.Any(e => e.Id == id);
        }

    }
}
