using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Entity;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Areas.Admin.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        TravelTripProjectEntities db = new TravelTripProjectEntities();
        // GET: Admin/About
        public ActionResult Edit()
        {
            var aboutData = db.About.FirstOrDefault();
            return View(aboutData);
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Edit(About hakkimizda)
        {
            if (ModelState.IsValid)
            {
                var aboutData = db.About.FirstOrDefault();
                aboutData.Description = hakkimizda.Description;
                aboutData.ImageUrl = hakkimizda.ImageUrl;
                db.SaveChanges();
                TempData["About"] = "Successfully updated...";
                

            }
            return View();
        }
    }
}
