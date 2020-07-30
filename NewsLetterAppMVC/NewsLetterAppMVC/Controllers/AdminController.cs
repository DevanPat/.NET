using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();

                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                var SignUpVMs = new List<SignUpVM>();
                foreach (var signup in signups)
                {
                    var SignUpVM = new SignUpVM();
                    SignUpVM.Id = signup.Id;
                    SignUpVM.FirstName = signup.FirstName;
                    SignUpVM.LastName = signup.LastName;
                    SignUpVM.EmailAddress = signup.EmailAddress;
                    SignUpVMs.Add(SignUpVM);
                }

                return View(SignUpVMs);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}