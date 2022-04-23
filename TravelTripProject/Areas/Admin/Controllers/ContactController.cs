using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Entity;

namespace TravelTripProject.Areas.Admin.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        // GET: Admin/Contact
        TravelTripProjectEntities db = new TravelTripProjectEntities();
        public ActionResult Messages()
        {
            var deger = db.Contact.OrderByDescending(i => i.Date).ToList();
            return View(deger);
        }

        public ActionResult Delete(int id)
        {
            var relatedMessage = db.Contact.Find(id);
            db.Contact.Remove(relatedMessage);
            db.SaveChanges();
            TempData["Delete"] = "The message successfully deleted...";
            return RedirectToAction("Messages");

        }
    }

}