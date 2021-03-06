using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Game.MVC.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
    }
    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<GameCreate> GameCreates { get; set; }
        public DbSet<ListGameDetails> ListGameDB { get; set; }
    }
}