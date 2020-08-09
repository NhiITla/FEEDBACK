using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FEEDBACK.Models;

namespace FEEDBACK.Areas.admin.Controllers
{
    public class Danhmuc_KSController : Controller
    {
        private CSDL_FEEDBACK db = new CSDL_FEEDBACK();

        // GET: admin/Danhmuc_KS
        public ActionResult Index()
        {
            return View(db.Danhmuc_KS.ToList());
        }

        // GET: admin/Danhmuc_KS/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_KS danhmuc_KS = db.Danhmuc_KS.Find(id);
            if (danhmuc_KS == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_KS);
        }

        // GET: admin/Danhmuc_KS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Danhmuc_KS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma_KS,maloai_KS,ten_coso,so_phong,so_giuong,diachi,dienthoai,email,ghichu")] Danhmuc_KS danhmuc_KS)
        {
            if (ModelState.IsValid)
            {
                db.Danhmuc_KS.Add(danhmuc_KS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhmuc_KS);
        }

        // GET: admin/Danhmuc_KS/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_KS danhmuc_KS = db.Danhmuc_KS.Find(id);
            if (danhmuc_KS == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_KS);
        }

        // POST: admin/Danhmuc_KS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma_KS,maloai_KS,ten_coso,so_phong,so_giuong,diachi,dienthoai,email,ghichu")] Danhmuc_KS danhmuc_KS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhmuc_KS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhmuc_KS);
        }

        // GET: admin/Danhmuc_KS/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_KS danhmuc_KS = db.Danhmuc_KS.Find(id);
            if (danhmuc_KS == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_KS);
        }

        // POST: admin/Danhmuc_KS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Danhmuc_KS danhmuc_KS = db.Danhmuc_KS.Find(id);
            db.Danhmuc_KS.Remove(danhmuc_KS);
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
