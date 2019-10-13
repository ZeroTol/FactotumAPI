using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FactotumAPI.Models;
using FactotumAPI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FactotumAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;

            //var user = new IdentityUser
            //{
            //    UserName = "five@one.com",
            //    Email = "five@one.com"
            //};
            //var result = userManager.CreateAsync(user, "P@ssword1").Result;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult CreateSimpleUser()
        {
            var user = new IdentityUser
            {
                UserName = "six@one.com",
                Email = "six@one.com"
            };

            var result = _userManager.CreateAsync(user, "P@ssword1").Result;

            return View("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
