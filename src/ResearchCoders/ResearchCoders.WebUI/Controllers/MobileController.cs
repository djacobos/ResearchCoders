using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResearchCoders.WebUI.Controllers
{
    public class MobileController : Controller
    {
        // GET: Mobile
        public ActionResult Index()
        {
            return View();
        }

		// GET: Mobile
		public ActionResult Fundamentals()
		{
			return View("~/Views/Mobile/2015/11/Fundamentals.cshtml");
		}

		// GET: Mobile
		public ActionResult CaseStudy1()
		{
			return View("~/Views/Mobile/2015/11/CaseStudy1.cshtml");
		}

		// GET: Mobile
		public ActionResult CaseStudy2()
		{
			return View("~/Views/Mobile/2015/11/CaseStudy2.cshtml");
		}

		// GET: Mobile
		public ActionResult CaseStudy3()
		{
			return View("~/Views/Mobile/2015/11/CaseStudy3.cshtml");
		}
    }
}