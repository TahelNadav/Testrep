using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Medicine.Models;

namespace Medicine.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Passwordmodel model)
        {
            string pass = "0";
            //Console.WriteLine(model.Password);
            if (model.Password == pass)
            {
                return RedirectToAction("Index", "AdminOps");
            }
            return RedirectToAction("Error");
        }

        public ActionResult Patient()
        {
            return RedirectToAction("Index", "Patient");
        }
        public ActionResult Doctor()
        {
            return RedirectToAction("Index", "Doctor");
        }
        public ActionResult Admin()
        {
            return RedirectToAction("Index", "Admin");
        }
        public ActionResult Catalog()
        {
            return RedirectToAction("Index", "Catalog");
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}