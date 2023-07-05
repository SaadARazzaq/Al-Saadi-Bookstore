using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _20F_0292_BCS_6E_Advanced_Programming_Final.Models;

namespace _20F_0292_BCS_6E_Advanced_Programming_Final.Controllers
{
    public class addBooksController : Controller
    {
        private bookstoreDBEntities db = new bookstoreDBEntities();
        public ActionResult Index()
        {
            return View(db.addBooks.ToList());
        }
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            addBook addBook = db.addBooks.Find(id);
            if (addBook == null)
            {
                return HttpNotFound();
            }
            return View(addBook);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Author,Description,Availability")] addBook addBook)
        {
            if (ModelState.IsValid)
            {
                db.addBooks.Add(addBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addBook);
        }
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            addBook addBook = db.addBooks.Find(id);
            if (addBook == null)
            {
                return HttpNotFound();
            }
            return View(addBook);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Title,Author,Description,Availability")] addBook addBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addBook);
        }
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            addBook addBook = db.addBooks.Find(id);
            if (addBook == null)
            {
                return HttpNotFound();
            }
            return View(addBook);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            addBook addBook = db.addBooks.Find(id);
            db.addBooks.Remove(addBook);
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
