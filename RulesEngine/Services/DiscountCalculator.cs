using RulesEngine.Services.DiscountRules;

namespace RulesEngine.Services
{
    public class DiscountCalculator
    {
        public decimal CalculateDiscountPercentage(Customer customer)
        {
            var rules = GetType().Assembly.GetTypes()
                .Where(p => typeof(IDiscountRule).IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IDiscountRule)
                .ToList();

            var engine = new DiscountRuleEngine(rules!);

            var result = engine.CalculateDiscount(customer);

            return result;
        }
    }
}
