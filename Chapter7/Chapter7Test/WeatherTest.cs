
using Chapter7.Services;
using Moq;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Chapter7.Components.Pages;

namespace Chapter7Test
{
    public class WeatherTest : TestContext
    {
        [Fact]
        public void WeatherComponent_Should_DisplayWeatherData_When_ServiceReturnsData()
        {
            // Arrange
            var mockWeatherService = new Mock<IWeatherService>();
            mockWeatherService.Setup(s => s.GetWeatherAsync(It.IsAny<string>())).ReturnsAsync("Sunny");

            Services.AddSingleton<IWeatherService>(mockWeatherService.Object);

            var cut = RenderComponent<WeatherComponent>();

            // Act
            cut.Find("button").Click();

            // Assert
            //cut.MarkupMatches("<div>Sunny</div>");
            var weatherDiv = cut.Find("div");
            weatherDiv.MarkupMatches("<div>Sunny</div>");
        }


    }
}
