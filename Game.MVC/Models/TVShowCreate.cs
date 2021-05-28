using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Game.MVC.Models
{
    public class TVShowCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter a name for the television show.")]
        [MaxLength(75, ErrorMessage = "There are too many characters, please shorten the name.")]
        public string Name { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}