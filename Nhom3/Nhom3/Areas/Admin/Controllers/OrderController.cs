using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nhom3.Model;

namespace Nhom3.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        private FlowerDB db = new FlowerDB();

        // GET: Admin/Cagetory
        public ActionResult Index()
        {
            var cHITIETDONHANGs = db.CHITIETDONHANGs.Include(c => c.DONHANG).Include(c => c.SANPHAM);
            return View(cHITIETDONHANGs.ToList());
        }

        // GET: Admin/Cagetory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETDONHANG cHITIETDONHANG = db.CHITIETDONHANGs.SingleOrDefault(m => m.MADONHANG == id);
            if (cHITIETDONHANG == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETDONHANG);
        }

        // GET: Admin/Cagetory/Create
        public ActionResult Create()
        {
            ViewBag.MADONHANG = new SelectList(db.DONHANGs, "MADONHANG", "MADONHANG");
            ViewBag.MASANPHAM = new SelectList(db.SANPHAMs, "MASANPHAM", "TENSANPHAM");
            return View();
        }

        // POST: Admin/Cagetory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MADONHANG,MASANPHAM,GHICHU,SOLUONG")] CHITIETDONHANG cHITIETDONHANG)
        {
            if (ModelState.IsValid)
            {
                db.CHITIETDONHANGs.Add(cHITIETDONHANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MADONHANG = new SelectList(db.DONHANGs, "MADONHANG", "MADONHANG", cHITIETDONHANG.MADONHANG);
            ViewBag.MASANPHAM = new SelectList(db.SANPHAMs, "MASANPHAM", "TENSANPHAM", cHITIETDONHANG.MASANPHAM);
            return View(cHITIETDONHANG);
        }

        // GET: Admin/Cagetory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETDONHANG cHITIETDONHANG = db.CHITIETDONHANGs.SingleOrDefault(m => m.MADONHANG == id);
            if (cHITIETDONHANG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MADONHANG = new SelectList(db.DONHANGs, "MADONHANG", "MADONHANG", cHITIETDONHANG.MADONHANG);
            ViewBag.MASANPHAM = new SelectList(db.SANPHAMs, "MASANPHAM", "TENSANPHAM", cHITIETDONHANG.MASANPHAM);
            return View(cHITIETDONHANG);
        }

        // POST: Admin/Cagetory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MADONHANG,MASANPHAM,GHICHU,SOLUONG")] CHITIETDONHANG cHITIETDONHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHITIETDONHANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MADONHANG = new SelectList(db.DONHANGs, "MADONHANG", "MADONHANG", cHITIETDONHANG.MADONHANG);
            ViewBag.MASANPHAM = new SelectList(db.SANPHAMs, "MASANPHAM", "TENSANPHAM", cHITIETDONHANG.MASANPHAM);
            return View(cHITIETDONHANG);
        }

        // GET: Admin/Cagetory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETDONHANG cHITIETDONHANG = db.CHITIETDONHANGs.SingleOrDefault(m => m.MADONHANG == id);
            if (cHITIETDONHANG == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETDONHANG);
        }

        // POST: Admin/Cagetory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CHITIETDONHANG cHITIETDONHANG = db.CHITIETDONHANGs.SingleOrDefault(m => m.MADONHANG == id);
            db.CHITIETDONHANGs.Remove(cHITIETDONHANG);
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
