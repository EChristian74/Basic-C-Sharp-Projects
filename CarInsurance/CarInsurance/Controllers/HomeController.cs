using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\timek\Documents\GitHub\Basic-C-Sharp-Projects\CarInsurance\CarInsurance\App_Data\Insurance.mdf;Integrated Security = True; MultipleActiveResultSets=True;Application Name = EntityFramework";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {

            string queryString = @"SELECT FirstName, LastName, EmailAddress, Quote from Insurees";

            List<QuoteSignUp> signups = new List<QuoteSignUp>();

            SqlConnection connectionString = new SqlConnection(this.connectionString);
            using (SqlConnection connection = connectionString)
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var signup = new QuoteSignUp();

                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.Quote = Convert.ToInt32(reader["Quote"]);

                    signups.Add(signup);
                }  
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}