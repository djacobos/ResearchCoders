using FluentAssertions;
using NUnit.Framework;
using WalmartAisleFinderApp.Domain;
using WalmartAisleFinderApp.Domain.Enum;

namespace WalmartAisleFinderApp.Tests
{
	[TestFixture]
    public class AisleFinderTest
    {
		private AisleFinder CreateFactory()
		{
			return new AisleFinder();
		}

		[Category("AisleFinder")]
		[Test]
		public void GivenValidCategoryToSearch_WhenAtWalmart_ThenReturnAisleNumber()
		{
			// Arrange
			AisleFinder aisleFinder = CreateFactory();
			
			//Act
			int aisleNumber = aisleFinder.Find(Category.Beverages);

			//Assert
			aisleNumber.Should().NotBe(0);
		}

		[Category("AisleFinder")]
		[Test]
		public void GivenValidCategoryToSearch_WhenAtWalmart_ThenReturnValidAisleNumber()
		{
			// Arrange
			AisleFinder aisleFinder = CreateFactory();
			int meatAisle = 50;

			//Act
			int aisleNumber = aisleFinder.Find(Category.MotorOil);

			//Assert
			aisleNumber.Should().Be(meatAisle);
		}
    }
}
