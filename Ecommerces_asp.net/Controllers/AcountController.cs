using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ecommerces_asp.net.Areas.Admin.Data;
namespace Ecommerces_asp.net.Controllers
{
   
   
    public class AcountController : Controller
    {
        
       
        private readonly MarketContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        
        public AcountController(UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager,
                                      MarketContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.Product = _context.Products;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {

            ViewBag.brand = _context.Suppliers;
            ViewBag.Category = _context.Categories;
            ViewBag.Product = _context.Products;

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Login user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(user);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
