using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;
using Medicine.Models;

namespace Medicine.Controllers
{
    public class CatalogController : Controller
    {
        // GET: DrugCatalog
        public ActionResult Index()
        {
            DrugCatalogModel model = new DrugCatalogModel();

            return View(model);
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
    }
}