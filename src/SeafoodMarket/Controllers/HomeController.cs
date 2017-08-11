using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeafoodMarket.ViewModels;
using SeafoodMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace SeafoodMarket.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUpForNews()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpForNews(SignUpForNewsViewModel model)
        {
            var db = new ApplicationDbContext();

            var newsletter = new Newsletter(model.Email, model.Preference);
            db.Newsletters.Add(newsletter);
            db.SaveChanges();
            return View("Confirmation", newsletter);
        }
    }
}
