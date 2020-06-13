using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BID_E.Models;
using Microsoft.Data.Sqlite;
using SQLite.Models;
using Microsoft.AspNetCore.Http;


namespace BID_E.Controllers
{
    
    public class LoginController : Controller
    {
        private ApplicationContext db;
        public LoginController(ApplicationContext _db)
        {
            db = _db;
        }


        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Login l)
        {
            if (ModelState.IsValid)
            {
                db.Login.Add(l);
                db.SaveChanges();

                ModelState.Clear();
                ViewBag.message = l.Username + " is successfully registered ";
                HttpContext.Session.SetString("UserId", l.UserId.ToString());
                return RedirectToAction("Welcome", "Login");
            }
            return View();
        }

        public ActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login user)
        {
            var account = db.Login.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            if(account != null)
            {
                HttpContext.Session.SetString("UserId", account.UserId.ToString());
                HttpContext.Session.SetString("Username", account.Username);
                return RedirectToAction("Welcome", "Login");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is incorrect");
            }
            return View();
        }

        public ActionResult Welcome()
        {
            if(HttpContext.Session.GetString("UserId") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public ActionResult WelcomeLoading()
        {
            return View();
        }
    }
}

