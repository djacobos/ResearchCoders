using System;
using System.Web;

namespace TheSuperClass.UI.Util
{
	public class TheSuperUtilClass
	{
		/// <summary>
		/// Check to see if the user is logged on.
		/// </summary>
		/// <returns></returns>
		public static bool IsLoggedIn()
		{
			try
			{
				if (HttpContext.Current.Session["userid"] != null)
					return true;
			}
			catch (Exception ex)
			{
				return false;
			}

			return false;
		}

		/// <summary>
		/// Does the logged on user have non admin access.
		/// </summary>
		/// <returns></returns>
		public static bool IsUser()
		{
			try
			{
				if (HttpContext.Current.Session["userisadmin"] != null 
					&& HttpContext.Current.Session["userisadmin"].ToString().ToLower() == "false")
					return true;
			}
			catch (Exception ex)
			{
				return false;
			}

			return false;
		}

		/// <summary>
		/// Does the logged on user have admin access.
		/// </summary>
		/// <returns></returns>
		public static bool IsAdmin()
		{
			try
			{
				if (HttpContext.Current.Session["userisadmin"] != null 
					&& HttpContext.Current.Session["userisadmin"].ToString().ToLower() == "true")
					return true;
			}
			catch (Exception ex)
			{
				return false;
			}

			return false;
		}

		/// <summary>
		/// Users will call this method which calls an API that returns a comma separated value file
		/// that the program loops thru and updates the database.
		/// </summary>
		public static void UpdateProductPrices()
		{
		}
	}
}
