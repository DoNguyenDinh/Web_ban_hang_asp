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
    public class CustommerAPIController : ControllerBase
    {
        private readonly MarketContext _content;
        public CustommerAPIController(MarketContext context)
        {
            _content = context;
        }
        public async Task<ActionResult<IEnumerable<Customer>>> GetCus()
        {
            return await _content.Customers.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCus(int id)
        {
            var cus = await _content.Customers.FindAsync(id);
            if (cus == null)
            {
                return NotFound();
            }
            return cus;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCus(int id, Customer cus)
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
        public async Task<ActionResult<Customer>> PostCus(Customer cus)
        {
            _content.Customers.Add(cus);
            await _content.SaveChangesAsync();
            return CreatedAtAction("GetCus", new { id = cus.Id }, cus);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> Delete(int id)
        {
            var cus = await _content.Customers.FindAsync(id);
            if (cus == null)
            {
                return NotFound();
            }
            _content.Customers.Remove(cus);
            await _content.SaveChangesAsync();
            return cus;
        }
        private bool CustommmerExists(int id)
        {
            return _content.Customers.Any(e => e.Id == id);
        }
    }
}
