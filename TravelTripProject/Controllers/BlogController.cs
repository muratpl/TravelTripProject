using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Entity;
using TravelTripProject.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace TravelTripProject.Controllers
{

    public class BlogController : Controller
    {
        // GET: Blog
        private TravelTripProjectEntities db = new TravelTripProjectEntities();

        BlogComment blogAndComment = new BlogComment();

        public ActionResult Index(int p = 1)
        {
            blogAndComment.lastBlogsAll = db.Blog.ToList().ToPagedList(p, 5);
            blogAndComment.lastBlogs5 = db.Blog.OrderByDescending(i => i.Date).Take(5).ToList();
            blogAndComment.lastComments5 = db.Comment.OrderByDescending(i => i.Date).Take(5).ToList();

            return View(blogAndComment);
        }

        public ActionResult BlogDetay(int id)
        {
            //List<Blog> relatedBlog = db.Blog.Where(x => x.Id == id).ToList();

            blogAndComment.relatedBlog = db.Blog.Where(x => x.Id == id).ToList();
            blogAndComment.lastCommentsAll = db.Comment.Where(x => x.BlogID == id).ToList();
            blogAndComment.lastBlogs5 = db.Blog.OrderByDescending(i => i.Date).Take(5).ToList();
            blogAndComment.lastComments5 = db.Comment.OrderByDescending(i => i.Date).Take(5).ToList();


            return View(blogAndComment);
        }

        [HttpGet]
        public PartialViewResult NewComment(int id)
        {
            ViewBag.BlogId = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult NewComment(Comment yorum)
        {
            if (ModelState.IsValid)
            {
                db.Comment.Add(yorum);
                db.SaveChanges();
                TempData["Comment"] = "Your comment has been sent successfully...";

            }
            return PartialView();
        }

      
    }
}