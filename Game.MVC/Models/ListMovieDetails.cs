using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Game.MVC.Models
{
    public class ListMovieDetails
    {
        [Key]
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        
        [Display(Name = "Added")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}