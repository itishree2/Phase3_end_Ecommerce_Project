using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp_Project_Laptop.Models;

namespace WebApp_Project_Laptop.Controllers
{
    public class ThinLightLaptopsController : Controller
    {
        private LaptopsDbEntities db = new LaptopsDbEntities();

        // GET: ThinLightLaptops
        public ActionResult Index()
        {
            return View(db.ThinLightLaptops.ToList());
        }

        // GET: ThinLightLaptops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThinLightLaptop thinLightLaptop = db.ThinLightLaptops.Find(id);
            if (thinLightLaptop == null)
            {
                return HttpNotFound();
            }
            return View(thinLightLaptop);
        }

        // GET: ThinLightLaptops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThinLightLaptops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,Price")] ThinLightLaptop thinLightLaptop)
        {
            if (ModelState.IsValid)
            {
                db.ThinLightLaptops.Add(thinLightLaptop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thinLightLaptop);
        }

        // GET: ThinLightLaptops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThinLightLaptop thinLightLaptop = db.ThinLightLaptops.Find(id);
            if (thinLightLaptop == null)
            {
                return HttpNotFound();
            }
            return View(thinLightLaptop);
        }

        // POST: ThinLightLaptops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Price")] ThinLightLaptop thinLightLaptop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thinLightLaptop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thinLightLaptop);
        }

        // GET: ThinLightLaptops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThinLightLaptop thinLightLaptop = db.ThinLightLaptops.Find(id);
            if (thinLightLaptop == null)
            {
                return HttpNotFound();
            }
            return View(thinLightLaptop);
        }

        // POST: ThinLightLaptops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThinLightLaptop thinLightLaptop = db.ThinLightLaptops.Find(id);
            db.ThinLightLaptops.Remove(thinLightLaptop);
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
