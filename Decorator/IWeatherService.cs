namespace Decorator;

public interface IWeatherService
{
    CurrentWeather GetCurrentWeather(string location);
}