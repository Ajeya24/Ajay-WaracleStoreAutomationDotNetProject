using System.Text.RegularExpressions;
using Microsoft.Playwright;
using WaracleProject.Config;

namespace WaracleProject.Pages
{
	public class HomePage
	{
		private readonly IPage page;
		private readonly TestConfig testConfig;
		public HomePage(IPage page, TestConfig testConfig)
		{
			this.page = page;
			this.testConfig = testConfig;
		}
		
		private ILocator SignInText => page.GetByRole(AriaRole.Button, new() { Name = "Sign out" });
		private ILocator ShopNow => page.Locator("(//div[@class='mt-9 flex flex-wrap gap-3']/a)[1]");
		
		
		public async Task ValidateLandedOnHomePageAsync()
		{
			await Assertions.Expect(SignInText).ToBeVisibleAsync();
		}
		
		public async Task ClickShopNowButtonOnHomePage()
		{ 
			
			await Assertions.Expect(ShopNow).ToBeVisibleAsync();
			await ShopNow.ClickAsync();
		}
	}
}

