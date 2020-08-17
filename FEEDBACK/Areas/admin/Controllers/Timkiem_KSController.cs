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
    public class Timkiem_KSController : Controller
    {
        private CSDL_FEEDBACK db = new CSDL_FEEDBACK();

        // GET: admin/Timkiem_KS
        public ActionResult Index()
        {
            return View(db.Loai_KS.ToList());
        }

        // GET: admin/Timkiem_KS/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loai_KS loai_KS = db.Loai_KS.Find(id);
            if (loai_KS == null)
            {
                return HttpNotFound();
            }
            return View(loai_KS);
        }

        // GET: admin/Timkiem_KS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Timkiem_KS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maloai_KS,ghichu")] Loai_KS loai_KS)
        {
            if (ModelState.IsValid)
            {
                db.Loai_KS.Add(loai_KS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loai_KS);
        }

        // GET: admin/Timkiem_KS/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loai_KS loai_KS = db.Loai_KS.Find(id);
            if (loai_KS == null)
            {
                return HttpNotFound();
            }
            return View(loai_KS);
        }

        // POST: admin/Timkiem_KS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maloai_KS,ghichu")] Loai_KS loai_KS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loai_KS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loai_KS);
        }

        // GET: admin/Timkiem_KS/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loai_KS loai_KS = db.Loai_KS.Find(id);
            if (loai_KS == null)
            {
                return HttpNotFound();
            }
            return View(loai_KS);
        }

        // POST: admin/Timkiem_KS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Loai_KS loai_KS = db.Loai_KS.Find(id);
            db.Loai_KS.Remove(loai_KS);
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
