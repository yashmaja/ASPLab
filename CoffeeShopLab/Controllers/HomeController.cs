using CoffeeShopLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        
        public IActionResult CompletedForm(string firstName, string lastName, string userEmail, string username, string phoneNum, DateTime dob, string size, byte[] avatar)
        {
            ViewData["firstName"] = firstName;
            ViewData["lastName"] = lastName;
            ViewData["userEmail"] = userEmail;
            ViewData["username"] = username;
            ViewData["phoneNum"] = phoneNum;
            ViewData["dob"] = dob;
            ViewData["size"] = size;
            ViewData["avatar"] = avatar;
            return View();
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
