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
			return false;
		}

		/// <summary>
		/// Does the logged on user have non admin access.
		/// </summary>
		/// <returns></returns>
		public static bool IsUser()
		{
			return false;
		}

		/// <summary>
		/// Does the logged on user have admin access.
		/// </summary>
		/// <returns></returns>
		public static bool IsAdmin()
		{
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
