using SimpleFactory.Auto;

namespace SimpleFactory
{
    interface IAutoFactory
    {
        IAuto CreateInstance(string carName);
    }

    public class AutoFactory : IAutoFactory
    {
        public IAuto CreateInstance(string carName)
        {
            switch (carName)
            {
                case "bmw":
                    return new Bmw();
                case "toyota":
                    return new Toyota();
            }

            throw new Exception("Invalid car name to create");
        }
    }
}
