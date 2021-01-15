using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ecommerces_asp.net.Areas.Admin.Data;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Ecommerces_asp.net.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly MarketContext _Context;
        public LoginController(MarketContext context)
        {
            _Context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Username,password")] Member member)
        {
            var r = _Context.Members.Where(m => (m.Username == member.Username && m.password == StringProcessing.CreateMD5Hash(member.password))).ToList();
            if (r.Count == 0)
            {
                return View("Index");
            }
            var str = JsonConvert.SerializeObject(member);
            HttpContext.Session.SetString("user", str);
            if (r[0].Rule == 0)
            {

                //var url = Url.RouteUrl("areas", new { controller = "Home", action = "Index", area = "Admin" });
                //return Redirect(url);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
