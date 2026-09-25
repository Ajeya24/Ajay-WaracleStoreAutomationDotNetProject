using Microsoft.Playwright;
using WaracleProject.Config;
namespace WaracleProject.Pages
{
	public class ShoppingCartPage
	{
		private readonly IPage page;
		private readonly TestConfig testConfig;
		
		public ShoppingCartPage(IPage page, TestConfig testConfig)
		{
			this.page = page;
			this.testConfig = testConfig;
		}

		private ILocator CouponCode => page.GetByPlaceholder("e.g. WARACLE25");
		private ILocator ApplyCouponButton => page.GetByRole(AriaRole.Button, new() { Name = "Apply" });
		
		private ILocator CouponInfoInCartSummary => page.Locator("//*[contains(text(),'–£0.25')]");
		
		private ILocator CouponAppliedMessage => page.GetByText("Coupon “WARACLE25” applied");

		private ILocator StandardShippingChargeNonEmptyBasket => page.Locator("//*[contains(text(),'£5.00')]");
		
		private ILocator ProceedToCheckoutButton=> page.GetByRole(AriaRole.Button, new() { Name = "Proceed to Checkout" });

		
		public async Task EnterCouponCode(string couponCode)
		{
			await CouponCode.FillAsync(couponCode);
				
		}

		public async Task ClickApplyCouponButton()
		{
			await ApplyCouponButton.ClickAsync();
		}
		
		public async Task ValidateCouponAppliedSuccessfullyAsync()
		{
			await Assertions.Expect(CouponAppliedMessage).ToBeVisibleAsync();
			
		}
		
		public async Task ValidateCouponInfoIsDisplayedInCartSummaryAsync()
		{
			await Assertions.Expect(CouponInfoInCartSummary).ToBeVisibleAsync();
		}
		
		public async Task ValidateStandardShippingChargesAppliedAsync()
		{
			await Assertions.Expect(StandardShippingChargeNonEmptyBasket).ToBeVisibleAsync();
		}

		public async Task ProceedToCheckoutAsync()
		{
			await ProceedToCheckoutButton.ClickAsync();
		}
		
		
	}
}

