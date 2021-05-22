using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Game.MVC.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
    }
}