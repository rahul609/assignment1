﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Carswebapp.Models;

namespace Carswebapp.Controllers
{
    public class Table_2Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_2
        public ActionResult Index()
        {
            return View(db.Table_2.ToList());
        }

        // GET: Table_2/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_2 table_2 = db.Table_2.Find(id);
            if (table_2 == null)
            {
                return HttpNotFound();
            }
            return View(table_2);
        }

        // GET: Table_2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumberPlate,carnumber,Cars,RentalPrice")] Table_2 table_2)
        {
            if (ModelState.IsValid)
            {
                db.Table_2.Add(table_2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_2);
        }

        // GET: Table_2/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_2 table_2 = db.Table_2.Find(id);
            if (table_2 == null)
            {
                return HttpNotFound();
            }
            return View(table_2);
        }

        // POST: Table_2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumberPlate,carnumber,Cars,RentalPrice")] Table_2 table_2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_2);
        }

        // GET: Table_2/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_2 table_2 = db.Table_2.Find(id);
            if (table_2 == null)
            {
                return HttpNotFound();
            }
            return View(table_2);
        }

        // POST: Table_2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Table_2 table_2 = db.Table_2.Find(id);
            db.Table_2.Remove(table_2);
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
