using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KinderGartenApp;

namespace KinderGartenApp.Controllers
{
    public class SASignUpsController : Controller
    {
        private KinderGartenEntities db = new KinderGartenEntities();

        // GET: SASignUps
        public ActionResult Index()
        {
            return View(db.SASignUps.ToList());
        }

        // GET: SASignUps/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SASignUp sASignUp = db.SASignUps.Find(id);
            if (sASignUp == null)
            {
                return HttpNotFound();
            }
            return View(sASignUp);
        }

        // GET: SASignUps/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
        // POST: SASignUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp([Bind(Include = "UserID,Name,Email,Password,ConfirmPassword")] SASignUp sASignUp)
        {
            if (ModelState.IsValid)
            {
                db.SASignUps.Add(sASignUp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sASignUp);
        }

        // GET: SASignUps/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SASignUp sASignUp = db.SASignUps.Find(id);
            if (sASignUp == null)
            {
                return HttpNotFound();
            }
            return View(sASignUp);
        }

        // POST: SASignUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Name,Email,Password,ConfirmPassword")] SASignUp sASignUp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sASignUp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sASignUp);
        }

        // GET: SASignUps/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SASignUp sASignUp = db.SASignUps.Find(id);
            if (sASignUp == null)
            {
                return HttpNotFound();
            }
            return View(sASignUp);
        }

        // POST: SASignUps/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SASignUp sASignUp = db.SASignUps.Find(id);
            db.SASignUps.Remove(sASignUp);
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
