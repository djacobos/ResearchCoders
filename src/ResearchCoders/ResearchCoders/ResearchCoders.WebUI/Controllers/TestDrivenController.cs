using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResearchCoders.WebUI.Controllers
{
    public class TestDrivenController : Controller
    {
        // GET: TestDriven
        public ActionResult Index()
        {
            return View();
        }

		// GET: TestDriven
		public ActionResult Fundamentals()
		{
			return View("~/Views/TestDriven/2015/11/Fundamentals.cshtml");
		}
    }
}