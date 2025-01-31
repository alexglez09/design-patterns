using Observer.Observers;
using Observer.Subject;

namespace Observer
{
    public class Runner
    {
        public void Run(
            WeatherMeasurements measurements,
            IConsoleAdapter consoleAdapter,
            decimal measurementsIncreaseFactor = 1.1m)
        {
            var weatherData = new WeatherData();
            var currentConditionsObserver = new CurrentConditionsObserver(weatherData, consoleAdapter);
            var forecastObserver = new ForecastObserver(weatherData, consoleAdapter);
            
            // ## Initial data: current conditions + forecast
            weatherData.WeatherMeasurements = measurements;

            // ## First update: forecast
            weatherData.UnRegister(currentConditionsObserver); // not needed yet
            weatherData.WeatherMeasurements = new WeatherMeasurements
            {
                Temperature = measurementsIncreaseFactor * weatherData.WeatherMeasurements.Temperature,
                Humidity = measurementsIncreaseFactor * weatherData.WeatherMeasurements.Humidity
            };

            // ## Second update: current conditions
            weatherData.Register(currentConditionsObserver);
            weatherData.UnRegister(forecastObserver); // not needed now
            weatherData.WeatherMeasurements = new WeatherMeasurements
            {
                Temperature = measurementsIncreaseFactor * weatherData.WeatherMeasurements.Temperature,
                Humidity = measurementsIncreaseFactor * weatherData.WeatherMeasurements.Humidity
            };
        }
    }
}
