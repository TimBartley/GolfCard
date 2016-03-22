using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GolfCardReader.Models;

namespace GolfCardReader.Controllers
{
    public class CardsController : Controller
    {

        private GolfCardDBContext db = new GolfCardDBContext();

        // GET: Cards
        public ActionResult Index()
        {
            return View(db.Cards.ToList());
        }

        // GET: Cards/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PlayerName,teeOff")] Card card)
        {
            if (ModelState.IsValid)
            {
                card.Date = DateTime.Now;
                db.Cards.Add(card);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(card);
        }

        // GET: Cards/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Card card = db.Cards.Find(id);
            if (card == null)
            {
                return HttpNotFound();
            }
            return View(card);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PlayerName,Score1,Score2,Score3,Score4,Score5,Score6,Score7,Score8,Score9")] Card card)
        {
            if (ModelState.IsValid)
            {
                card.Date = DateTime.Now;
                db.Entry(card).State = EntityState.Modified;
                db.Entry(card).Property(x => x.teeOff).IsModified = false;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(card);
        }

        // GET: Cards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Card card = db.Cards.Find(id);
            if (card == null)
            {
                return HttpNotFound();
            }
            return View(card);
        }

        // POST: Cards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Card card = db.Cards.Find(id);
            db.Cards.Remove(card);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
