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
    public class addUsersController : Controller
    {
        private bookstoreDBEntities db = new bookstoreDBEntities();
        public ActionResult Index()
        {
            return View(db.addUsers.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            addUser addUser = db.addUsers.Find(id);
            if (addUser == null)
            {
                return HttpNotFound();
            }
            return View(addUser);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Age,Gender,Address,Password")] addUser addUser)
        {
            if (ModelState.IsValid)
            {
                db.addUsers.Add(addUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addUser);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            addUser addUser = db.addUsers.Find(id);
            if (addUser == null)
            {
                return HttpNotFound();
            }
            return View(addUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Age,Gender,Address,Password")] addUser addUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addUser);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            addUser addUser = db.addUsers.Find(id);
            if (addUser == null)
            {
                return HttpNotFound();
            }
            return View(addUser);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            addUser addUser = db.addUsers.Find(id);
            db.addUsers.Remove(addUser);
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
