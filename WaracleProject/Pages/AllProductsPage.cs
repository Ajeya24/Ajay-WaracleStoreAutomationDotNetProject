using Microsoft.Playwright;
using WaracleProject.Config;
namespace WaracleProject.Pages
{
	public class AllProductsPage
	{
		private readonly IPage page;
		private readonly TestConfig testConfig;
		public AllProductsPage(IPage page, TestConfig testConfig)
		{
			this.page = page;
			this.testConfig = testConfig;
		}

		private ILocator GreyTshirt => page.GetByText("Men's Grey T-Shirt");

		private ILocator AddtoCartButtonPDP => page.Locator("//*[contains(text(),'Add to Cart')]");
		private ILocator ViewCartButtonPDP => page.Locator("//*[contains(text(),'View Cart')]");
		
		
		
		public async Task AddAccessoryToCartAsync()
		{
			await Assertions.Expect(GreyTshirt).ToBeVisibleAsync();
			await GreyTshirt.ClickAsync();
			
		}
		
		public async Task AddTheItemToCartAsync()
		{
			await AddtoCartButtonPDP.ClickAsync();
			await ViewCartButtonPDP.ClickAsync();
			
		}
	}
}

