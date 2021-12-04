using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var signups = db.Insurees;
                
                foreach (var signup in signups) 
                {
                    signup.Id = signup.Id; //Passes "Id" to the View
                    signup.FirstName = signup.FirstName; //Property field mapping
                    signup.LastName = signup.LastName; //Property field mapping
                    signup.EmailAddress = signup.EmailAddress; //Property field mapping
                }
                return View(signups); 
            }
        }
    }
}