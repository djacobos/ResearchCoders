using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResearchCoders.WebUI.Controllers
{
    public class SolidDesignController : Controller
    {
        // GET: SolidDesign
        public ActionResult Index()
        {
            return View();
        }

		// GET: SolidDesign
		public ActionResult Fundamentals()
		{
			return View("~/Views/SolidDesign/2015/11/Fundamentals.cshtml");
		}

		// GET: SolidDesign
		public ActionResult CaseStudy1()
		{
			return View("~/Views/SolidDesign/2015/11/CaseStudy1.cshtml");
		}
    }
}