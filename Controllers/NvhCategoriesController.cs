﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NvhK22cntt3Lession11_2210900031.Models;

namespace NvhK22cntt3Lession11_2210900031.Controllers
{
    public class NvhCategoriesController : Controller
    {
        private NvhK22CNTLesion11DbEntities1 db = new NvhK22CNTLesion11DbEntities1();

        // GET: NvhCategories
        public ActionResult NvhIndex()
        {
            return View(db.NvhCategory.ToList());
        }

        // GET: NvhCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhCategory nvhCategory = db.NvhCategory.Find(id);
            if (nvhCategory == null)
            {
                return HttpNotFound();
            }
            return View(nvhCategory);
        }

        // GET: NvhCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NvhCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NvhID,NvhCateName,NvhStatus")] NvhCategory nvhCategory)
        {
            if (ModelState.IsValid)
            {
                db.NvhCategory.Add(nvhCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nvhCategory);
        }

        // GET: NvhCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhCategory nvhCategory = db.NvhCategory.Find(id);
            if (nvhCategory == null)
            {
                return HttpNotFound();
            }
            return View(nvhCategory);
        }

        // POST: NvhCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NvhID,NvhCateName,NvhStatus")] NvhCategory nvhCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvhCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvhCategory);
        }

        // GET: NvhCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhCategory nvhCategory = db.NvhCategory.Find(id);
            if (nvhCategory == null)
            {
                return HttpNotFound();
            }
            return View(nvhCategory);
        }

        // POST: NvhCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NvhCategory nvhCategory = db.NvhCategory.Find(id);
            db.NvhCategory.Remove(nvhCategory);
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
