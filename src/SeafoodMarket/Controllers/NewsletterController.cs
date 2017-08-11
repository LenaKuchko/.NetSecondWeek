using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SeafoodMarket.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SeafoodMarket.Controllers
{
    [Authorize]
    public class NewsletterController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        //to pass test needs to uncomment

        public NewsletterController()
        {

        }

        public NewsletterController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View( "Index", _db.Newsletters.ToList());
            // for passing tests
            //return View("Index");

        }
    }
}
