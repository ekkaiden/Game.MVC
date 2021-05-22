using Game.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game.MVC.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        private GameDbContext _db = new GameDbContext();
        public ActionResult Index()
        {
            return View(_db.Games.ToList());
        }
        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GameType game)
        {
            if (ModelState.IsValid)
            {
                _db.Games.Add(game);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }
    }
}