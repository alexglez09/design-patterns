namespace TemplateMethod
{
    public class Coffee : Beverage
    {
        protected override string PourInCup()
        {
            return "Pouring coffee.";
        }
    }
}
