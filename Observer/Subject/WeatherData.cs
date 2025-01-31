namespace Observer.Subject
{
    public class WeatherData : AbstractSubject
    {
        private WeatherMeasurements weatherMeasurements = null!;

        public WeatherMeasurements WeatherMeasurements
        {
            get => this.weatherMeasurements;
            set
            {
                this.weatherMeasurements = value;
                Notify();
            }
        }
    }
}
