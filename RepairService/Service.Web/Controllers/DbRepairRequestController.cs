using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Service.Web.Models;

namespace Service.Web.Controllers
{
    public class DbRepairRequestController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        public ActionResult Index()
        {
            return View(db.RepairRequests.ToList());
        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbRepairRequest dbRepairRequest = db.RepairRequests.Find(id);
            if (dbRepairRequest == null)
            {
                return HttpNotFound();
            }
            return View(dbRepairRequest);
        }

        // GET: DbRideRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DbRideRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Filled,FullName,Price,NonSmokingDriver,BabySeat")] DbRepairRequest dbRepairRequest)
        {
            if (ModelState.IsValid)
            {
                db.RepairRequests.Add(dbRepairRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbRepairRequest);
        }

        // GET: DbRideRequests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbRepairRequest dbRepairRequest = db.RepairRequests.Find(id);
            if (dbRepairRequest == null)
            {
                return HttpNotFound();
            }
            return View(dbRepairRequest);
        }

        // POST: DbRideRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Filled,FullName,Price,NonSmokingDriver,BabySeat")] DbRepairRequest dbRepairRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbRepairRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbRepairRequest);
        }

        // GET: DbRideRequests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbRepairRequest dbRepairRequest = db.RepairRequests.Find(id);
            if (dbRepairRequest == null)
            {
                return HttpNotFound();
            }
            return View(dbRepairRequest);
        }

        // POST: DbRideRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DbRepairRequest dbRepairRequest = db.RepairRequests.Find(id);
            dbRepairRequest.Faults.Clear();
            db.RepairRequests.Remove(dbRepairRequest);
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
