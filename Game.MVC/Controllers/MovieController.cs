using Game.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game.MVC.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        private MovieDbContext _db = new MovieDbContext();
        // GET: Movie
        public ActionResult Index()
        {
            var model = new ListMovieDetails[0];
            return View(model);
        }
        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieCreate movieCreate)
        {
            if (ModelState.IsValid)
            {
                _db.MovieCreates.Add(movieCreate);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieCreate);
        }
    }
}