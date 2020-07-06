﻿using NewsLetterAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using NewsLetterAppMVC.ViewModels;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=LAPTOP-HVJORDUF\SQLEXPRESS;Initial Catalog = Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }    


                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                //                        (@FirstName, @LastName, @EmailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                        

                //}
                    return View("Success");
            }
        }

        public ActionResult Admin()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signups = db.SignUps;
                var SignUpVMs = new List<SignUpVM>();
                foreach (var signup in signups)
                {
                    var SignUpVM = new SignUpVM();
                    SignUpVM.FirstName = signup.FirstName;
                    SignUpVM.LastName = signup.LastName;
                    SignUpVM.EmailAddress = signup.EmailAddress;
                    SignUpVMs.Add(SignUpVM);
                }

                return View(SignUpVMs);
            }


        }

    }
}