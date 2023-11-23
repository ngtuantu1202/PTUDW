using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThiGKNguyenTuanTu_63135967.Models;

namespace ThiGKNguyenTuanTu_63135967.Controllers
{
    public class CongTy_63135967Controller : Controller
    {
        private ThiGK_63135967Entities db = new ThiGK_63135967Entities();

        // GET: CongTy_63135967
        public ActionResult Index()
        {
            return View(db.CONGTies.ToList());
        }

        // GET: CongTy_63135967/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGTY cONGTY = db.CONGTies.Find(id);
            if (cONGTY == null)
            {
                return HttpNotFound();
            }
            return View(cONGTY);
        }

        // GET: CongTy_63135967/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CongTy_63135967/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCT,TenCT,DiaChi")] CONGTY cONGTY)
        {
            if (ModelState.IsValid)
            {
                db.CONGTies.Add(cONGTY);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cONGTY);
        }

        // GET: CongTy_63135967/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGTY cONGTY = db.CONGTies.Find(id);
            if (cONGTY == null)
            {
                return HttpNotFound();
            }
            return View(cONGTY);
        }

        // POST: CongTy_63135967/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCT,TenCT,DiaChi")] CONGTY cONGTY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONGTY).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cONGTY);
        }

        // GET: CongTy_63135967/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGTY cONGTY = db.CONGTies.Find(id);
            if (cONGTY == null)
            {
                return HttpNotFound();
            }
            return View(cONGTY);
        }

        // POST: CongTy_63135967/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CONGTY cONGTY = db.CONGTies.Find(id);
            db.CONGTies.Remove(cONGTY);
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
