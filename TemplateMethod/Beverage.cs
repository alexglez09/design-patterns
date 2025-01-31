using System.Text;

namespace TemplateMethod
{
    public interface IBeverage
    {
        string PrepareRecipe();
    }

    public abstract class Beverage : IBeverage
    {
        public string PrepareRecipe()
        {
            var result = new StringBuilder();

            result.Append(BoilWater());
            result.Append(PourInCup());
            result.Append(AddCondiments());

            return result.ToString();
        }

        private string BoilWater()
        {
            return "Boiling water.";
        }

        protected abstract string PourInCup();

        protected virtual string AddCondiments()
        {
            return "Adding sugar.";
        }
    }
}