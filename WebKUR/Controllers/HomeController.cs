using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKUR.Models;
using WebKUR.ViewModels;

namespace WebKUR.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
       
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        [OutputCache(Duration = 50, Location = System.Web.UI.OutputCacheLocation.Server,VaryByParam ="genre")]
        public ActionResult Index()
        {
            var user = _context.Users.ToList();
            return View(user);
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
        public ActionResult Delete(string  id)
        {

            var users = _context.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var users = _context.Users.Find(id);
            _context.Users.Remove(users);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(ApplicationUser user)
        {
            if (!ModelState.IsValid)
            {
                return View("Home", user);
            }

            if (user.Id == "")
                _context.Users.Add(user);
            else
            {
                var customerInDb = _context.Users.Single(c => c.Id == user.Id);
                customerInDb.UserName = user.UserName;
                customerInDb.AccessFailedCount = user.AccessFailedCount;
                customerInDb.DrivingLicense = user.DrivingLicense;
                customerInDb.Email = user.Email;
                customerInDb.EmailConfirmed = user.EmailConfirmed;
                customerInDb.Id = customerInDb.Id;               
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


        public ActionResult Details(string id)
        {
            var users = _context.Users.SingleOrDefault(c => c.Id == id);

            if (users == null)
                return HttpNotFound();

            return View(users);
        }

        public ActionResult Edit(string id)
        {
            var users = _context.Users.SingleOrDefault(c => c.Id == id);

            if (users == null)
                return HttpNotFound();

       

            return View("Details", users);
        }
    }
}