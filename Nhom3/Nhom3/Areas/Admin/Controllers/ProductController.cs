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
    public class ProductController : Controller
    {
        private FlowerDB db = new FlowerDB();

        // GET: Admin/Product
        public ActionResult Index()
        {
            var sANPHAMs = db.SANPHAMs.Include(s => s.DANHMUCCON).Include(s => s.DANHMUCCON1);
            return View(sANPHAMs.ToList());
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON");
            ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON");
            return View();
        }

        // POST: Admin/Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MASANPHAM,TENSANPHAM,MOTA,HOACHINH,HOAPHU,CHIEUNGANG,CHIEUCAO,GIABAN,GIAKM,MADANHMUCCON")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.SANPHAMs.Add(sANPHAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON", sANPHAM.MADANHMUCCON);
            ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON", sANPHAM.MADANHMUCCON);
            return View(sANPHAM);
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            
            ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON", sANPHAM.MADANHMUCCON);
            ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON", sANPHAM.MADANHMUCCON);
            return View(sANPHAM);
        }

        // POST: Admin/Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MASANPHAM,TENSANPHAM,MOTA,HOACHINH,HOAPHU,CHIEUNGANG,CHIEUCAO,GIABAN,GIAKM,MADANHMUCCON")] SANPHAM sANPHAM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(sANPHAM).State = EntityState.Modified;
                    db.SaveChanges();
                    
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON", sANPHAM.MADANHMUCCON);
                ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON", sANPHAM.MADANHMUCCON);
                return View(sANPHAM);
            }

            
          //  ViewBag.MADANHMUCCON = new SelectList(db.DANHMUCCONs, "MADANHMUCCON", "TENDANHMUCCON", sANPHAM.MADANHMUCCON);
            
            
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            try
            {
                db.SANPHAMs.Remove(sANPHAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Không thể xóa sản phẩm này, Mã lỗi: " + ex.Message;
                return View(sANPHAM);
            }

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
