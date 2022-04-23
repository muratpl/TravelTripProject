using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Contact
    {
        public Contact()
        {
            Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name&Surname is required.")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Mail is required.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Phone Number is required.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Message is required.")]
        [StringLength(500, ErrorMessage = "Please enter at least 20 characters long...", MinimumLength = 20)]
        public string Message { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; private set;}
    }
}