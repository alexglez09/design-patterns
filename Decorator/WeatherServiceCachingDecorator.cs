namespace Decorator
{
    public class WeatherServiceCachingDecorator : IWeatherService
    {
        private readonly IWeatherService weatherService;
        private readonly IWeatherCache weatherCache;
        
        public WeatherServiceCachingDecorator(
            IWeatherService weatherService,
            IWeatherCache weatherCache)
        {
            this.weatherService = weatherService;
            this.weatherCache = weatherCache;
        }

        public CurrentWeather GetCurrentWeather(string location)
        {
            var currentWeather = this.weatherCache.GetCurrentWeather(location);

            if (currentWeather != null)
            {
                return currentWeather;
            }

            currentWeather = this.weatherService.GetCurrentWeather(location);

            return currentWeather;
        }
    }
}
