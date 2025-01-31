using RulesEngine.Services;

namespace RulesEngine
{
    public class Runner
    {
        public decimal Run(Customer customer)
        {
            var discountCalculator = new DiscountCalculator();

            var result = discountCalculator.CalculateDiscountPercentage(customer);

            return result;
        }
    }
}
