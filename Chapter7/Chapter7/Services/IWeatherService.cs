namespace Chapter7.Services
{
    public interface IWeatherService
    {
        Task<string> GetWeatherAsync(string location);

        Task<string> GetWeatherAsync();
    }
}
