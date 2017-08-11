using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeafoodMarket.ViewModels;
using SeafoodMarket.Models;

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
        public IActionResult SignUpForNews(SignUpForNewsModel model)
        {
            var visitor = new Visitor(model.Email, model.Preference);
            var news = new Newsletter();
            visitor.newsletter = news;

            //db.Visitors.Add(visitor);
            db.SaveChanges();

            

            return View();
        }

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View();
        //}
    }
}
