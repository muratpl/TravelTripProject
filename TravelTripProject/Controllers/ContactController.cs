using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Entity;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        TravelTripProjectEntities db = new TravelTripProjectEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ContactForm()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult ContactForm(Contact iletisim)
        {
            if (ModelState.IsValid)
            {
                db.Contact.Add(iletisim);
                db.SaveChanges();
                TempData["Message"] = "Your message has been sent successfully...";

            }
            return PartialView();

        }
    }
}