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
    public class AccountController : Controller
    {
        private FlowerDB db = new FlowerDB();

        // GET: Admin/Account
        public ActionResult Index()
        {
            var tAIKHOANs = db.TAIKHOANs.Include(t => t.KHACHHANG).Include(t => t.QUYEN);
            return View(tAIKHOANs.ToList());
        }

        // GET: Admin/Account/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        // GET: Admin/Account/Create
        public ActionResult Create()
        {
            ViewBag.MAKH = new SelectList(db.KHACHHANGs, "MAKH", "TENKH");
            ViewBag.TENQUYEN = new SelectList(db.QUYENs, "TENQUYEN", "MOTA");
            return View();
        }

        // POST: Admin/Account/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MATAIKHOAN,TENDANGNHAP,MATKHAU,TRANGTHAI,MAKH,TENQUYEN")] TAIKHOAN tAIKHOAN)
        {
            if (ModelState.IsValid)
            {
                db.TAIKHOANs.Add(tAIKHOAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MAKH = new SelectList(db.KHACHHANGs, "MAKH", "TENKH", tAIKHOAN.MAKH);
            ViewBag.TENQUYEN = new SelectList(db.QUYENs, "TENQUYEN", "MOTA", tAIKHOAN.TENQUYEN);
            return View(tAIKHOAN);
        }

        // GET: Admin/Account/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MAKH = new SelectList(db.KHACHHANGs, "MAKH", "TENKH", tAIKHOAN.MAKH);
            ViewBag.TENQUYEN = new SelectList(db.QUYENs, "TENQUYEN", "TENQUYEN", tAIKHOAN.TENQUYEN);
            return View(tAIKHOAN);
        }

        // POST: Admin/Account/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MATAIKHOAN,TENDANGNHAP,MATKHAU,TRANGTHAI,MAKH,TENQUYEN")] TAIKHOAN tAIKHOAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tAIKHOAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MAKH = new SelectList(db.KHACHHANGs, "MAKH", "TENKH", tAIKHOAN.MAKH);
            ViewBag.TENQUYEN = new SelectList(db.QUYENs, "TENQUYEN", "TENQUYEN", tAIKHOAN.TENQUYEN);
            return View(tAIKHOAN);
        }

        // GET: Admin/Account/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        // POST: Admin/Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            db.TAIKHOANs.Remove(tAIKHOAN);
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
