namespace SimpleFactory
{
    public class Runner
    {
        public string Run(string model)
        {
            IAutoFactory autoFactory = new AutoFactory();
            var auto = autoFactory.CreateInstance(model);

            var result = auto.Drive();

            return result;
        }
    }
}
