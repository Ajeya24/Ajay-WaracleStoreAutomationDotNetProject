using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using WaracleProject.Config;


namespace WaracleProject.Pages
{
	public class LoginPage
	{
		private readonly IPage page;
		private readonly TestConfig testConfig;
		public LoginPage(TestConfig testConfig,IPage page)
		{
			this.page = page;
			this.testConfig = testConfig;

		}

       
        private ILocator UsernameInputBox => page.GetByLabel("Email");
        private ILocator PasswordInputBox => page.Locator("#password");
        private ILocator MyyAccountLink => page.GetByRole(AriaRole.Button, new() { Name = "Account", Exact = true });
        private ILocator LoginButton => page.GetByRole(AriaRole.Button, new() { Name = "Sign In" });


        public async Task NavigateToBaseUrlAsync()
        {
	        var baseUrl = testConfig.GetBaseUrl();
	        await page.GotoAsync(baseUrl);
        }
        
        public async Task LoginWithValidCredentialsAsync(string username, string password)
		{
			await MyyAccountLink.ClickAsync();
			await UsernameInputBox.FillAsync(username);
			await PasswordInputBox.FillAsync(password);
			await LoginButton.ClickAsync();
		}
    }
}

