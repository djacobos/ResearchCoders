using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResearchCoders.WebUI.Helpers.Language;

namespace ResearchCoders.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		// GET: AboutUs
		public ActionResult AboutUs()
		{
			return View();
		}

	    public ActionResult ChangeLanguage(string language)
	    {
		    new SiteLanguages().SetLanguage(language);

			return Redirect(HttpContext.Request.UrlReferrer.ToString());		    
	    }
    }
}