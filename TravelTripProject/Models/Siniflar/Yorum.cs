using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Comment
    {
        public Comment()
        {
            Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string CommentText { get; set; }
        public int BlogID { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; private set; }
        public int? CommentLike { get; set; }

        //navigation properties
        [ForeignKey("BlogID")]
        public virtual Blog blog { get; set; }
    }
}