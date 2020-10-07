using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicine.Controllers
{
    public class DrugDataController : Controller
    {
        // GET: DrugData
        public ActionResult Index()
        {
            return View();
        }
    }
}