namespace TemplateMethod
{
    public class Tea : Beverage
    {
        protected override string PourInCup()
        {
            return "Pouring tea.";
        }

        protected override string AddCondiments()
        {
            return "Adding lemon.";
        }
    }
}
