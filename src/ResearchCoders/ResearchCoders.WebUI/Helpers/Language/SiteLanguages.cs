using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace ResearchCoders.WebUI.Helpers.Language
{
	public class SiteLanguages
	{
		public static List<Languages> AvailableLanguages = new List<Languages>
		{
			new Languages() {FullName = "[US] English", CultureName = "en", ImagePath = "~/Content/assets/images/flags/us.png"},
			new Languages() {FullName = "[MX] Spanish", CultureName = "es-MX", ImagePath = "~/Content/assets/images/flags/mx.png"}
		};

		public static bool IsLanguageAvailable(string language)
		{
			return AvailableLanguages
				.FirstOrDefault(x => x.CultureName.Equals(language)) != null;
		}

		public static string GetDefaultLanguage()
		{
			return AvailableLanguages[0].CultureName;
		}

		public void SetLanguage(string language)
		{
			try
			{
				if (!IsLanguageAvailable(language))
					language = GetDefaultLanguage();

				var cultureInfo = new CultureInfo(language);
				Thread.CurrentThread.CurrentUICulture = cultureInfo;
				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);

				HttpCookie langCookie = new HttpCookie("culture", language);
				langCookie.Expires = DateTime.Now.AddYears(1);
				HttpContext.Current.Response.Cookies.Add(langCookie);
			}
			catch (Exception)
			{
				
				throw;
			}
		}
	}
}