using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Game.MVC.Models
{
    public class TVShow
    {
        public int TVShowID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
    }
    public class TVShowDbContext : DbContext
    {
        public DbSet<TVShow> TVShows { get; set; }
        public DbSet<TVShowCreate> TVShowCreates { get; set; }
    }
}