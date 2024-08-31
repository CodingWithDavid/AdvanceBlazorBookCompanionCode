using System.Threading.Tasks;
using Microsoft.Playwright;
using Xunit;


namespace Chapter7Test
{
    public class PlaywrightTest
    {
        [Fact]
        public async Task BlazorApp_Should_DisplayHomePage()
        {
            using var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://localhost:7245/");

            var headerText = await page.InnerTextAsync("h1");
            Assert.Equal("Hello, world!", headerText);
        }

    }
}
