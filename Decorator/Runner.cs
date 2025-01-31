namespace Decorator
{
    public class Runner
    {
        public CurrentWeather Run(
            IWeatherService weatherService,
            IWeatherCache weatherCache,
            string location)
        {
            IWeatherService weatherServiceCachingDecorator = new WeatherServiceCachingDecorator(
                weatherService,
                weatherCache);

            return weatherServiceCachingDecorator.GetCurrentWeather(location);
        }
    }
}
