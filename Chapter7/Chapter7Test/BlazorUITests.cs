
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Chapter7Test
{
    public class BlazorUITests
    {

        [Fact]
        public void BlazorApp_Should_DisplayHomePage()
        {
            using var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:7245/");

            var header = driver.FindElement(By.TagName("h1"));
            var UUT = header.Text;
            Assert.Equal("Hello, world!", UUT);
        }
    }
}
