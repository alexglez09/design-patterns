namespace RulesEngine.Services.DiscountRules
{
    public class FirstTimeCustomerRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer)
        {
            return customer.DateOfFirstPurchase == default ? 0 : 0.15m;
        }
    }
}
