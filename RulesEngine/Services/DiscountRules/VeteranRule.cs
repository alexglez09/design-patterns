namespace RulesEngine.Services.DiscountRules
{
    public class VeteranRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer)
        {
            return customer.IsVeteran ? 0.10m : 0;
        }
    }
}
