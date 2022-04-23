using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class BlogComment
    {
        public virtual IEnumerable<Blog> relatedBlog { get; set; }
        public virtual IEnumerable<Comment> lastComments5 { get; set; }
        public virtual IEnumerable<Comment> lastCommentsAll { get; set; }
        public virtual IEnumerable<Blog> lastBlogs5 { get; set; }
        public virtual IEnumerable<Blog> lastBlogsAll { get; set; }
    }
}