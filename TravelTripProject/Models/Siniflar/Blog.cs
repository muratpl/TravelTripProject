using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Blog
    {
        public Blog()
        {
            this.Commentlar = new HashSet<Comment>();
            Date = DateTime.Now;
        }

        [Key]
        [Display(Name = "Blog Id")]
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; private set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Resim URL")]
        public string BlogImage { get; set; }
        [Display(Name = "Beğeni Sayısı")]
        public int? LikeCount { get; set; }


        public virtual ICollection<Comment> Commentlar { get; set; }
    }
}