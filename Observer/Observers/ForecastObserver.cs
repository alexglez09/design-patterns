using Observer.Subject;

namespace Observer.Observers
{
    public class ForecastObserver : AbstractObserver
    {
		private readonly WeatherData weatherData;
		private readonly IConsoleAdapter consoleAdapter;

		public ForecastObserver(WeatherData weatherData, IConsoleAdapter consoleAdapter)
		{
			this.weatherData = weatherData;
			weatherData.Register(this);
			this.consoleAdapter = consoleAdapter;
		}

		public override void Update()
		{
			var temperature = weatherData.WeatherMeasurements.Temperature;
			var humidity = weatherData.WeatherMeasurements.Humidity;

			// some custom logic
			temperature += 13.3m;
			humidity -= 1;

			var forecast = $"Forecast: {temperature}F degrees and {humidity}% humidity.";

			this.consoleAdapter.WriteToConsole(forecast);
		}
	}
}
