using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResearchCoders.WebUI.Controllers
{
    public class DesignPatternController : Controller
    {
        // GET: DesignPattern
        public ActionResult Index()
        {
            return View();
        }

		// GET: DesignPattern
		public ActionResult Fundamentals()
		{
			return View("~/Views/DesignPattern/2015/11/Fundamentals.cshtml");
		}

		// GET: DesignPattern
		public ActionResult CaseStudy1()
		{
			return View("~/Views/DesignPattern/2015/11/CaseStudy1.cshtml");
		}
    }
}