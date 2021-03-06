﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lecznica.Models;

namespace Lecznica.Controllers
{
    public class StoreroomController : Controller
    {
        private LecznicaDBContext db = new LecznicaDBContext();

        // GET: Storeroom
        public ActionResult Index()
        {
            return View(db.Storeroom.ToList());
        }

        // GET: Storeroom/Details/5
    /*    public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Storeroom storeroom = db.Storeroom.Find(id);
            if (storeroom == null)
            {
                return HttpNotFound();
            }
            return View(storeroom);
        }
        */
        // GET: Storeroom/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Storeroom/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nazwa_produktu")] Storeroom storeroom)
        {
            if (ModelState.IsValid)
            {
                db.Storeroom.Add(storeroom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(storeroom);
        }

        // GET: Storeroom/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Storeroom storeroom = db.Storeroom.Find(id);
            if (storeroom == null)
            {
                return HttpNotFound();
            }
            return View(storeroom);
        }

        // POST: Storeroom/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Imie,Nazwisko,Telefon")] Storeroom storeroom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(storeroom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(storeroom);
        }

        // GET: Storeroom/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Storeroom storeroom = db.Storeroom.Find(id);
            if (storeroom == null)
            {
                return HttpNotFound();
            }
            return View(storeroom);
        }

        // POST: Storeroom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Storeroom storeroom = db.Storeroom.Find(id);
            db.Storeroom.Remove(storeroom);
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

    public class Storeroom
    {
    }
}
