namespace Decorator;

public interface IWeatherCache
{
    CurrentWeather GetCurrentWeather(string location);
}