using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;

namespace Medicine.Controllers
{
    public class AddPatientController : Controller
    {
        // GET: AddPatient
        public ActionResult Index()
        {
            return View();
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
        public ActionResult AddPatient(Patient patient)
        {
            Console.WriteLine(patient.FirstName);

            return RedirectToAction("Index");
        }

    }
}
