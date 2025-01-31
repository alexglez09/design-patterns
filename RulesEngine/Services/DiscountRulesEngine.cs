using RulesEngine.Services.DiscountRules;

namespace RulesEngine.Services
{
    public class DiscountRuleEngine
    {
        private readonly List<IDiscountRule> rules = new();

        public DiscountRuleEngine(List<IDiscountRule> newRules)
        {
            this.rules.AddRange(newRules);
        }

        public decimal CalculateDiscount(Customer customer)
        {
            var discount = 0m;

            foreach (var rule in this.rules)
            {
                var newDiscount = rule.CalculateDiscount(customer);

                discount = Math.Max(discount, newDiscount);
            }

            return discount;
        }
    }
}
