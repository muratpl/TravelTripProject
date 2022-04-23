using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Entity;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        private TravelTripProjectEntities db = new TravelTripProjectEntities();
        // GET: About
        public ActionResult Index()
        {
            return View(db.About.ToList());
        }

       


    }
}