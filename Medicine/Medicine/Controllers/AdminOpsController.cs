using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicine.Controllers
{
    public class AdminOpsController : Controller
    {
        // GET: AdminOps
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

        public ActionResult AddPatient()
        {
            return RedirectToAction("Index", "AddPatient");
        }
        public ActionResult AddDoctor()
        {
            return RedirectToAction("Index", "AddDoctor");
        }

        public ActionResult DrugData()
        {
            return RedirectToAction("Index", "DrugData");
        }

        public ActionResult EditDrugCatalog()
        {
            return RedirectToAction("Index", "EditDrugCatalog");
        }
        public ActionResult EditDoctor()
        {
            return RedirectToAction("Index", "EditDoctor");
        }
        public ActionResult DeleteDoctor()
        {
            return RedirectToAction("Index", "DeleteDoctor");
        }
        public ActionResult EditPatient()
        {
            return RedirectToAction("Index", "EditPatient");
        }
        public ActionResult DeletePatient()
        {
            return RedirectToAction("Index", "DeletePatient");
        }
    }
}