using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Entity;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {

        TravelTripProjectEntities db = new TravelTripProjectEntities();

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Administrator admin)
        {

            if (ModelState.IsValid)
            {
                var bilgiler = db.Admin.FirstOrDefault(x => x.User == admin.User && x.Password == admin.Password);
                if (bilgiler != null)
                {
                    FormsAuthentication.SetAuthCookie(bilgiler.User, true);
                    Session["Kullanici"] = bilgiler.User.ToString();
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                    ModelState.AddModelError("", "EMail veya şifre hatalı!");
                }
                
            }
            return View(admin);


        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}