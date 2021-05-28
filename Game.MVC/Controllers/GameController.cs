using DocumentFormat.OpenXml.Office2010.Excel;
using Game.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game.MVC.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        // GET: Game
        private GameDbContext _db = new GameDbContext();
        //public ActionResult Index()
        //{
        //    return View(_db.Games.ToList());
        //}
        //public ActionResult Index()
        //{
        //    var model = new ListGameDetails[0];
        //    return View(model);
        //}
        public ActionResult Index()
        {
            List<ListGameDetails> gameList = _db.ListGameDB.ToList();
            List<ListGameDetails> gameAlph = gameList.OrderBy(game => game.Name).ToList();
            return View(gameAlph);
        }
        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Game/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GameCreate gameCreate)
        {
            if (ModelState.IsValid)
            {
                _db.GameCreates.Add(gameCreate);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameCreate);
        }
        //GET : Delete
        //Game/Delete/{name}
        public ActionResult Delete(int? number)
        {
            if (number == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            ListGameDetails listGameDetails = _db.ListGameDB.Find(number);
            if (listGameDetails == null)
            {
                return HttpNotFound();
            }
            return View(listGameDetails);
        }
        //POST : Delete
        //Product/Delete/{name}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int number)
        {
            ListGameDetails listGameDetails = _db.ListGameDB.Find(number);
            _db.ListGameDB.Remove(listGameDetails);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}