using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Image Url")]
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}