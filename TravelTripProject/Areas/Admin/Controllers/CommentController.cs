using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Entity;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Areas.Admin.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        TravelTripProjectEntities db = new TravelTripProjectEntities();
        // GET: Admin/Comment
        public ActionResult Index()
        {
            var comments = db.Comment.OrderByDescending(i => i.Date).ToList();

            return View(comments);
        }

        public ActionResult Delete(int id)
        {
            var relatedComment = db.Comment.Find(id);
            db.Comment.Remove(relatedComment);
            db.SaveChanges();

            TempData["DeleteComment"] = "Comment successfully deleted...";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var relatedComment = db.Comment.Find(id);
            return View(relatedComment);
        }

        [HttpPost]
        public ActionResult Update(Comment yorum)
        {
            db.Entry(yorum).State = EntityState.Modified;
            db.SaveChanges();
            TempData["UpdateComment"] = "Comment successfully updated...";
            return RedirectToAction("Index");
        }
        

    }
}