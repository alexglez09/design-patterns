namespace RulesEngine.Services.DiscountRules
{
    public interface IDiscountRule
    {
        decimal CalculateDiscount(Customer customer);
    }
}
