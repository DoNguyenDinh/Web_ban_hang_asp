using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Ecommerces_asp.net.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
            Member mem = new Member();
            mem.Username = us.SelectToken("Username").ToString();
            mem.password = us.SelectToken("password").ToString();
            mem.Rule = Int32.Parse(us.SelectToken("Rule").ToString());
            return View(mem);
        }
    }
}
