using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Entity;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Test

        private TravelTripProjectEntities db = new TravelTripProjectEntities();

        public ActionResult Index()
        {
            var blog = db.Blog.ToList();
            return View(blog);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var blog = db.Blog.OrderByDescending(x => x.Date).Take(2).ToList();
            return PartialView(blog);
        }

        public PartialViewResult Partial2()
        {
            var blog = db.Blog.OrderByDescending(x => x.Date).Skip(2).Take(1).ToList();
            return PartialView(blog);
        }
        public PartialViewResult Partial3()
        {
            var blog = db.Blog.OrderByDescending(x => x.Date).Take(10).ToList();
            return PartialView(blog);
        }

        public PartialViewResult Partial4()
        {
            var blog = db.Blog.OrderByDescending(x => x.LikeCount).Take(3).ToList();
            return PartialView(blog);
        }
        public PartialViewResult Partial5()
        {
            var blog = db.Blog.OrderByDescending(x => x.LikeCount).Skip(3).Take(3).ToList();
            return PartialView(blog);
        }
    }
}