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
