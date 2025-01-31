namespace Strategy.Shipping
{
    public interface IShippingCostStrategy
    {
        decimal Calculate(Order order);
    }
}
