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
    public class BlogController : Controller
    {
        TravelTripProjectEntities db = new TravelTripProjectEntities();
        // GET: Admin/Blog


        public ActionResult Index()
        {
            var deger = db.Blog.OrderByDescending(i => i.Date).ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog blog)

        {
            db.Blog.Add(blog);
            db.SaveChanges();
            TempData["Create"] = "Blog post created successfully...";
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var relatedBlog = db.Blog.Find(id);
            db.Blog.Remove(relatedBlog);
            db.SaveChanges();
            TempData["Delete"] = "Blog post deleted successfully...";
            return RedirectToAction("Index");

        }

        public ActionResult Update(int id)
        {
            var relatedBlog = db.Blog.Find(id);
            return View(relatedBlog);
        }

        [HttpPost]
        public ActionResult Update(Blog blog)
        {
            //var relatedBlog = db.Blog.Find(blog.Id);
            //relatedBlog.Baslik = blog.Baslik;

            //if (blog.Date != null)
            //{
            //    relatedBlog.Date = blog.Date;
            //}

            //relatedBlog.Description = blog.Description;
            //relatedBlog.BlogImage = blog.BlogImage;
            //relatedBlog.LikeCount = blog.LikeCount;
            //db.SaveChanges();
            //TempData["Update"] = "Blog post successfully updated...";
            //return RedirectToAction("Index");

            db.Entry(blog).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Update"] = "Blog post successfully updated...";
            return RedirectToAction("Index");
        }
    }
}
