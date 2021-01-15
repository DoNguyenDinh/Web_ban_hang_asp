using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ecommerces_asp.net.Areas.Admin.Data;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerces_asp.net.Areas.Admin
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesAPIController : ControllerBase
    {
        private readonly MarketContext _content;
        public CategoriesAPIController(MarketContext context)
        {
            _content = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _content.Categories.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategories(int id)
        {
            var categories = await _content.Categories.FindAsync(id);
            if (categories == null)
            {
                return NotFound();
            }
            return categories;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCate(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }
            _content.Entry(category).State = EntityState.Modified;
            try
            {
                await _content.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriesExists(id))
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
        public async Task<ActionResult<Category>> Postcate(Category category)
        {
            _content.Categories.Add(category);
            await _content.SaveChangesAsync();
            return CreatedAtAction("GetCategories", new { id = category.Id }, category);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> Delete(int id)
        {
            var cate = await _content.Categories.FindAsync(id);
            if (cate == null)
            {
                return NotFound();
            }
            _content.Categories.Remove(cate);
            await _content.SaveChangesAsync();
            return cate;
        }
        private bool CategoriesExists(int id)
        {
            return _content.Categories.Any(e => e.Id == id);
        }
    }
}

