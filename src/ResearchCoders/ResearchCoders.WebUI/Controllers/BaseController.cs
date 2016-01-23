using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResearchCoders.WebUI.Helpers.Language;

namespace ResearchCoders.WebUI.Controllers
{
    public class BaseController : Controller
    {
	    protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
	    {
		    string language = null;
		    HttpCookie languageCookie = Request.Cookies["culture"];
		    if (languageCookie != null)
		    {
			    language = languageCookie.Value;
		    }
		    else
		    {
			    var userLanguage = Request.UserLanguages;
			    var userLang = userLanguage != null ? userLanguage[0] : "";
			    if (userLang != "")
			    {
				    language = userLang;
			    }
			    else
			    {
				    language = SiteLanguages.GetDefaultLanguage();
			    }
		    }

			new SiteLanguages().SetLanguage(language);
		    return base.BeginExecuteCore(callback, state);
	    }
    }
}