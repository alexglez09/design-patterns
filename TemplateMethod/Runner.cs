namespace TemplateMethod
{
    public class Runner
    {
        public string Run(string beverageName)
        {
            IBeverage beverage;

            switch (beverageName)
            {
                case "coffee":
                    beverage = new Coffee();
                    return beverage.PrepareRecipe();
                case "tea":
                    beverage = new Tea();
                    return beverage.PrepareRecipe();
            }

            throw new Exception("Invalid beverageName.");
        }
    }
}
