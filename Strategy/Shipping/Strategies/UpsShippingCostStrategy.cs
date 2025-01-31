namespace Strategy.Shipping.Strategies
{
    public class UpsShippingCostStrategy : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            return order.Destination.PostalCode.StartsWith("111")
                ? 5m
                : 20m;
        }
    }
}
