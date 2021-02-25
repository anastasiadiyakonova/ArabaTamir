﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VTYSProje.Entity;

namespace VTYSProje.Controllers
{
    [Authorize(Roles ="admin")]
    public class Category1Controller : Controller
    {
        private VTYSProjeEntities db = new VTYSProjeEntities();

        // GET: Category1
        public ActionResult Index()
        {
            return View(db.Category1.ToList());
        }

        // GET: Category1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category1 category1 = db.Category1.Find(id);
            if (category1 == null)
            {
                return HttpNotFound();
            }
            return View(category1);
        }

        // GET: Category1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,brandId")] Category1 category1)
        {
            if (ModelState.IsValid)
            {
                db.Category1.Add(category1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category1);
        }

        // GET: Category1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category1 category1 = db.Category1.Find(id);
            if (category1 == null)
            {
                return HttpNotFound();
            }
            return View(category1);
        }

        // POST: Category1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,brandId")] Category1 category1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category1);
        }

        // GET: Category1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category1 category1 = db.Category1.Find(id);
            if (category1 == null)
            {
                return HttpNotFound();
            }
             category1 = db.Category1.Find(id);
            db.Category1.Remove(category1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //// POST: Category1/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Category1 category1 = db.Category1.Find(id);
        //    db.Category1.Remove(category1);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
