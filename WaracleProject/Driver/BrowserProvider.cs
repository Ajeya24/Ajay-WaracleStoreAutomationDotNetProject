using Microsoft.Playwright;


namespace WaracleProject.Driver
{
    public class BrowserProvider
    {
        private IPlaywright? playwright;
        private IBrowser? browser;

        public async Task<IPage> CreatePageAsync()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            var context = await browser.NewContextAsync();
            return await context.NewPageAsync();
        }

        public async Task DisposeAsync()
        {
            if(browser != null)
            {
                await browser.CloseAsync();
            }
            playwright?.Dispose();
        }
    }
}