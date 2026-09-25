using Microsoft.Playwright;
using WaracleProject.Config;
namespace WaracleProject.Pages
{
	public class OrderSummaryPage
	{
		private readonly IPage page;
		private readonly TestConfig testConfig;
		public OrderSummaryPage(IPage page, TestConfig testConfig)
		{
			this.page = page;
			this.testConfig = testConfig;
		}
		
		private ILocator AddressInputBox => page.GetByPlaceholder("10 Digital Drive");
		
		private ILocator CityInputBox => page.GetByPlaceholder("Edinburgh");
		
		private ILocator PostCodeInputBox => page.GetByPlaceholder("EH1 1AA");
		
		private ILocator CardNumberInputBox => page.GetByPlaceholder("4242 4242 4242 4242");
		
		private ILocator ExpiryDateInputBox => page.GetByPlaceholder("12 / 26");
		
		private ILocator CVVInputBox => page.GetByPlaceholder("123");

		private ILocator PayButtonOrderSummaryPage => page.Locator("(//*[contains(text(),'Pay')])[3]");
		
		public async Task EnterShippingAddressAsync(string Address,string city,string postCode)
		{
			await AddressInputBox.FillAsync(Address);
			await CityInputBox.FillAsync(city);
			await PostCodeInputBox.FillAsync(postCode);
			
		}
		
		public async Task EnterPaymentDetailsAsync(string cardNumber,string expiryDate,string cvv)
		{
			await CardNumberInputBox.FillAsync(cardNumber);
			await ExpiryDateInputBox.FillAsync(expiryDate);
			await CVVInputBox.FillAsync(cvv);
			
		}
		public async Task ClickOnPayOnOrderSummaryPageAsync()
		{
			await PayButtonOrderSummaryPage.ClickAsync();
		}
	}
}


		

