using Microsoft.Playwright;
using WaracleProject.Config;
namespace WaracleProject.Pages
{
	public class OrderConfirmationPage
	{
		private readonly IPage page;
		private readonly TestConfig testConfig;
		public OrderConfirmationPage(IPage page, TestConfig testConfig)
		{
			this.page = page;
			this.testConfig = testConfig;
		}

		private ILocator CouponAppliedMessageOrderConfirmationPage => page.GetByText("Coupon (WARACLE25)");
		private ILocator TotalPaidOrderConfirmationPage => page.GetByText("Total Paid");

		public async Task ConfirmOrder()
		{
			await Assertions.Expect(CouponAppliedMessageOrderConfirmationPage).ToBeVisibleAsync();
			await Assertions.Expect(TotalPaidOrderConfirmationPage).ToBeVisibleAsync();
		}
	}
}

