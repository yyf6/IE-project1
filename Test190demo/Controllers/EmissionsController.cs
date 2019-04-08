using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test190demo.Models;

namespace Test190demo.Controllers
{
    public class EmissionsController : Controller
    {
        private EA db = new EA();
        public static string subarea { get; set; }

        // GET: Emissions
        public ActionResult Index()
        {
            ViewBag.sub = subarea;
            return View(db.Emissions.ToList());
        }

        // GET: Emissions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emission emission = db.Emissions.Find(id);
            if (emission == null)
            {
                return HttpNotFound();
            }
            return View(emission);
        }

        // GET: Emissions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emissions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "report_id,facility_id,substance_id,jurisdiction_facility_id,facility_name,registered_business_name,primary_anzsic_class_code,primary_anzsic_class_name,substance_name,air_total_emission_kg,suburb,postcode,latitude,longitude")] Emission emission)
        {
            if (ModelState.IsValid)
            {
                db.Emissions.Add(emission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emission);
        }

        // GET: Emissions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emission emission = db.Emissions.Find(id);
            if (emission == null)
            {
                return HttpNotFound();
            }
            return View(emission);
        }

        // POST: Emissions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "report_id,facility_id,substance_id,jurisdiction_facility_id,facility_name,registered_business_name,primary_anzsic_class_code,primary_anzsic_class_name,substance_name,air_total_emission_kg,suburb,postcode,latitude,longitude")] Emission emission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emission);
        }

        // GET: Emissions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emission emission = db.Emissions.Find(id);
            if (emission == null)
            {
                return HttpNotFound();
            }
            return View(emission);
        }

        // POST: Emissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emission emission = db.Emissions.Find(id);
            db.Emissions.Remove(emission);
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

        [HttpGet]
        public ActionResult SearchSub()
        {
            string sub = Request.Form["sub"];
            return View();
        }

        [HttpPost]
        public ActionResult SearchSub(FormCollection formCollection)
        {
            subarea = formCollection["sub"];
            return RedirectToAction("Index");
        }
    }
}
