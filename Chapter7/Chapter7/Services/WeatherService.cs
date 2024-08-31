using System.Diagnostics;

namespace Chapter7.Services
{
    public class WeatherService : IWeatherService
    {

        private readonly DiagnosticSource _diagnosticSource;

        public WeatherService(DiagnosticSource diagnosticSource)
        {
            _diagnosticSource = diagnosticSource;
        }

        public async Task<string> GetWeatherAsync()
        {
            _diagnosticSource.Write("WeatherService.GetWeather.Start", new { });
            try
            {
                // Simulate API call
                await Task.Delay(500); // Simulate delay
                _diagnosticSource.Write("WeatherService.GetWeather.End", new { Weather = "Sunny, 25°C" });
                return "Sunny, 25°C";
            }
            catch (Exception ex)
            {
                _diagnosticSource.Write("WeatherService.GetWeather.Error", new { Exception = ex });
                throw;
            }
        }

        public async Task<string> GetWeatherAsync(string location)
        {
            // Simulate an API call or database query to get weather data.
            // In a real scenario, this would involve HTTP requests, database queries, etc.

            await Task.Delay(500); // Simulate async work

            // This is just a placeholder. You'd replace this with real logic to fetch weather data.
            return "Sunny";
        }
    }

}
