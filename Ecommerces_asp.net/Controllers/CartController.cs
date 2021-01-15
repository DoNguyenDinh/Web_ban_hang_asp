using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerces_asp.net.Areas.Admin.Models;
using Ecommerces_asp.net.Helpers;
using Microsoft.AspNetCore.Mvc;
using Ecommerces_asp.net.Areas.Admin.Data;
namespace Ecommerces_asp.net.Controllers
{
    [Route("cart")]
   
    public class CartController : Controller
    {
        public readonly MarketContext _context;
        public CartController(MarketContext context)
        {
            _context = context;
        }
    
            [Route("index")]
        public IActionResult Index()
        {
            ViewBag.pro = _context.Products.Where(m => m.Discount != 0);
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.Product = _context.Products;
            var cart = SessionHelper.GetOjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.product.UnitPrice * item.quantity);
            return View();
        }
        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            //var product = _context.Products.Find(id);
            
            if (SessionHelper.GetOjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                //List<Item> cart = new List<Item>();
                var cart = new List<Item>();
                cart.Add(new Item
                {
                    product = _context.Products.Find(id),
                    quantity = 1
                });
                SessionHelper.SetOjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetOjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id, cart);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        product = _context.Products.Find(id),
                        quantity = 1

                    });
                   
                }
                else
                {
                    //int newQuantity = cart[index].quantity++;
                    //cart[index].quantity = newQuantity; ;
                    cart[index].quantity++;

                }
                SessionHelper.SetOjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index","Cart");
            

        }
        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetOjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id, cart);
            cart.RemoveAt(index);
            SessionHelper.SetOjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index","Cart");
        }
        private int isExist(int id,List<Item>cart)
        {
            
            for(int i = 0; i < cart.Count; i++)
            {
                if (cart[i].product.Id==id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
