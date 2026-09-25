using System;
using Microsoft.Playwright;
using Reqnroll;
using WaracleProject.Pages;

namespace WaracleProject.StepDefinitions
{
	[Binding]
	public class E2EStepDefinition
	{
		private readonly IPage page;
		private readonly LoginPage loginPage;
		private readonly HomePage homePage;
		private readonly ShoppingCartPage shoppingCartPage;
		private readonly AllProductsPage allProductsPage;
		private readonly OrderSummaryPage orderSummaryPage;
		private readonly OrderConfirmationPage orderConfirmationPage;

		public E2EStepDefinition(LoginPage loginPage, IPage page, HomePage homePage, ShoppingCartPage shoppingCartPage, AllProductsPage allProductsPage, OrderSummaryPage orderSummaryPage, OrderConfirmationPage orderConfirmationPage)
		{
			this.page = page;
			this.loginPage = loginPage;
			this.homePage = homePage;
			this.shoppingCartPage = shoppingCartPage;
			this.allProductsPage = allProductsPage;
			this.orderSummaryPage = orderSummaryPage;
			this.orderConfirmationPage = orderConfirmationPage;
		}

		[Given("User launches the Waracle store")]
		public async Task GivenUserLaunchesTheWaracleStore()
		{
			await loginPage.NavigateToBaseUrlAsync();
			

		}
		

		[When("User logs using valid {string} and {string} credentials")]
		public async Task WhenUserLogsUsingValidAndCredentials(string username, string password)
		{
			await loginPage.LoginWithValidCredentialsAsync(username, password);
			
		}

		[Then("User should land successfully on the home page of the Waracle store")]
		public async Task ThenUserShouldLandSuccessfullyOnTheHomePageOfTheWaracleStore()
		{
			await homePage.ValidateLandedOnHomePageAsync();
			
		}

		[Then("User clicks on Shop Now button")]
		public async Task ThenUserClicksOnShopNowButton()
		{
			await homePage.ClickShopNowButtonOnHomePage();
		}

		[Then("User adds an item to the cart")]
		public  async Task ThenUserAddsAnItemToTheCart()
		{
			await allProductsPage.AddAccessoryToCartAsync();
			await allProductsPage.AddTheItemToCartAsync();
		}


		[Then("User enters the {string}")]
		public async Task ThenUserEntersThe(string couponCode)
		{
			await shoppingCartPage.EnterCouponCode(couponCode);
		}

		[Then("User applies the coupon code")]
		public async Task ThenUserAppliesTheCouponCode()
		{
			await shoppingCartPage.ClickApplyCouponButton();
			
		}

		[Then("validate whether the appropriate message is displayed for the applied coupon code")]
		public async Task ThenValidateWhetherTheAppropriateMessageIsDisplayedForTheAppliedCouponCode()
		{
			await shoppingCartPage.ValidateCouponAppliedSuccessfullyAsync();
		}

		[Then("validate that coupon applied is displayed in the cart summary")]
		public async Task ThenValidateThatCouponAppliedIsDisplayedInTheCartSummary()
		{
			await shoppingCartPage.ValidateCouponInfoIsDisplayedInCartSummaryAsync();
		}

		[Then("validate that shipping charges are displayed to non empty basket")]
		public async Task ThenValidateThatShippingChargesAreDisplayedToNonEmptyBasket()
		{
			await shoppingCartPage.ValidateStandardShippingChargesAppliedAsync();
		}

		[Then("User user proceeds to checkout")]
		public async Task ThenUserUserProceedsToCheckout()
		{
			 await shoppingCartPage.ProceedToCheckoutAsync();
		}
		
		
		[Then("User enters Shipping Address {string}{string}{string}")]
		public async Task ThenUserEntersShippingAddress(string Address, string city, string postCode)
		{
			await orderSummaryPage.EnterShippingAddressAsync(Address, city, postCode);
		}

		[Then("User enters Payment Details {string}{string}{string}")]
		public async Task ThenUserEntersPaymentDetails(string CardNumber, string ExpiryDate, string CVC)
		{
			await orderSummaryPage.EnterPaymentDetailsAsync(CardNumber, ExpiryDate, CVC);
		}

		[Then("User clicks on pay button on Order Summary page")]
		public async Task ThenUserClicksOnPayButtonOnOrderSummaryPage()
		{
			await orderSummaryPage.ClickOnPayOnOrderSummaryPageAsync();
		}

		[Then("validate that total and coupon applied is displayed on Order Confirmation page")]
		public async Task ThenValidateThatTotalAndCouponAppliedIsDisplayedOnOrderConfirmationPage()
		{
			await orderConfirmationPage.ConfirmOrder();
		}
	}
}

