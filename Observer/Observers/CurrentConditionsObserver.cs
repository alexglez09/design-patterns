using Observer.Subject;

namespace Observer.Observers
{
    public class CurrentConditionsObserver : AbstractObserver
    {
		private readonly WeatherData weatherData;
		private readonly IConsoleAdapter consoleAdapter;

		public CurrentConditionsObserver(WeatherData weatherData, IConsoleAdapter consoleAdapter)
		{
			this.weatherData = weatherData;
			weatherData.Register(this);
			this.consoleAdapter = consoleAdapter;
		}

		public override void Update()
        {
            var temperature = weatherData.WeatherMeasurements.Temperature;
            var humidity = weatherData.WeatherMeasurements.Humidity;

            var conditions = $"Current conditions: {temperature}F degrees and {humidity}% humidity.";

            this.consoleAdapter.WriteToConsole(conditions);
        }
    }
}
