using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

    // GET: Insuree
    public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {

            decimal baseCost = 50; //Creates variable that establishes base quote cost 
                                   //cost on which the entire quote will be built upon
            var age = insuree.DateOfBirth; //Creates age variable that will be used in age condition
            var ageCalculation = DateTime.Today.Year - age.Year; //Creates variable that will 
                                                                 //calculate age for age condition
            

            //Instantiates base cost of monthly quote cost before any other conditions are validated
            if (1 == 1)
            {
                insuree.Quote += baseCost;
            }

            //If the user is 18 and under, add $100 to the monthly total
            if (ageCalculation < 18)
            {
                insuree.Quote += 100;
            }

            //If the user is between 19 and 25, add $50 to the monthly total
            if ((ageCalculation > 18) && (ageCalculation < 26))
            {
                insuree.Quote += 50;
            }

            //If the user is over 25, add $25 to the monthly total
            if (ageCalculation > 25)
            {
                insuree.Quote += 25;
            }

            //If the car's year is before 2000, add $25 to the monthly total
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25;
            }

            //If the car's year is after 2015, add $25 to the monthly total
            if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25;
            }

            //If the car's Make is a Porsche, add $25 to the price
            if (insuree.CarMake == "Porsche")
            {
                insuree.Quote += 25;
            }

            //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price
            if ((insuree.CarMake == "Porsche") && (insuree.CarModel == "911 Carrera"))
            {
                insuree.Quote += 25;
            }

            //Add $10 to the monthly total for every speeding ticket the user has
            if (insuree.SpeedingTickets > 0)
            {
                insuree.Quote += (insuree.SpeedingTickets * 10);
            }

            //If the user has ever had a DUI, add 25% to the total
            if (insuree.DUI == true)
            {
                decimal decDUI = 1.25m;
                insuree.Quote *= decDUI;
            }

            //If it's full coverage, add 50% to the total
            if (insuree.CoverageType == true)
            {
                decimal decFull = 1.50m;
                insuree.Quote *= decFull;
            }

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Table.Id, etc.
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
