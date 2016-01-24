using System;
using NUnit.Framework;

namespace WalmartAisleFinderApp.Tests
{
	/// <summary>
	/// I would usually put this class in another file.
	/// </summary>
	public static class AisleManager
	{
		public static int FindByCategory(Category category)
		{
			return Convert.ToInt32(category);
		}
	}

	/// <summary>
	/// I would usually put this enum in another file.
	/// </summary>
	public enum Category
	{
		Dairy = 10,
		Electronics = 46,
		Apparel = 12
	}

	[TestFixture]
	public class AisleFinder
	{
		[Test]
		public void GivenProductCategory_WhenAtWalmart_ThenReturnAisleNumber()
		{			
			Assert.That(AisleManager.FindByCategory(Category.Dairy).Equals(10));
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException), 
		ExpectedMessage="Please search by Category")]
		public void GivenNoCategory_WhenAtWalmart_ThenReturnError()
		{
			Assert.Throws<NullReferenceException>(() => AisleManager.FindByCategory(Category.Dairy));
		}
	}
}
