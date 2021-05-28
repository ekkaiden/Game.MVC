using Game.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game.MVC.Controllers
{
    [Authorize]
    public class TVShowController : Controller
    {
        private TVShowDbContext _db = new TVShowDbContext();
        // GET: TVShow
        public ActionResult Index()
        {
            var model = new ListTVShowDetails[0];
            return View(model);
        }
        // GET: TVShow/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: TVShow/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TVShowCreate tVShowCreate)
        {
            if (ModelState.IsValid)
            {
                _db.TVShowCreates.Add(tVShowCreate);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tVShowCreate);
        }
    }
}