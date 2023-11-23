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
    public class DichVu_63135967Controller : Controller
    {
        private ThiGK_63135967Entities db = new ThiGK_63135967Entities();

        // GET: DichVu_63135967
        public ActionResult Index()
        {
            var dICHVUs = db.DICHVUs.Include(d => d.CONGTY);
            return View(dICHVUs.ToList());
        }

        // GET: DichVu_63135967/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DICHVU dICHVU = db.DICHVUs.Find(id);
            if (dICHVU == null)
            {
                return HttpNotFound();
            }
            return View(dICHVU);
        }

        // GET: DichVu_63135967/Create
        public ActionResult Create()
        {
            ViewBag.MaCT = new SelectList(db.CONGTies, "MaCT", "TenCT");
            return View();
        }

        // POST: DichVu_63135967/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDV,TenDV,NgayCapNhat,GiaDV,AnhDaiDien,MaCT")] DICHVU dICHVU)
        {
            if (ModelState.IsValid)
            {
                db.DICHVUs.Add(dICHVU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaCT = new SelectList(db.CONGTies, "MaCT", "TenCT", dICHVU.MaCT);
            return View(dICHVU);
        }

        // GET: DichVu_63135967/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DICHVU dICHVU = db.DICHVUs.Find(id);
            if (dICHVU == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaCT = new SelectList(db.CONGTies, "MaCT", "TenCT", dICHVU.MaCT);
            return View(dICHVU);
        }

        // POST: DichVu_63135967/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDV,TenDV,NgayCapNhat,GiaDV,AnhDaiDien,MaCT")] DICHVU dICHVU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dICHVU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaCT = new SelectList(db.CONGTies, "MaCT", "TenCT", dICHVU.MaCT);
            return View(dICHVU);
        }

        // GET: DichVu_63135967/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DICHVU dICHVU = db.DICHVUs.Find(id);
            if (dICHVU == null)
            {
                return HttpNotFound();
            }
            return View(dICHVU);
        }

        // POST: DichVu_63135967/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DICHVU dICHVU = db.DICHVUs.Find(id);
            db.DICHVUs.Remove(dICHVU);
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
