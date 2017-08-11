using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeafoodMarket.ViewModels;
using SeafoodMarket.Models;
using Microsoft.AspNetCore.Authorization;

namespace SeafoodMarket.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ApplicationDbContext _db;

        //public HomeController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}

        private ApplicationDbContext db = new ApplicationDbContext();
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
            var newsletter = new Newsletter(model.Email, model.Preference);
            db.Newsletters.Add(newsletter);
            db.SaveChanges();
            return View("Confirmation", newsletter);
        }


        //[Authorize]
        public IActionResult ShowMailingList()
        {
            return View("ShowMailingList", db.Newsletters.ToList());
        }
    }
}
