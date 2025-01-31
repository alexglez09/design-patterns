namespace Strategy.Shipping.Strategies
{
    public class FedExShippingCostStrategy : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            return order.Destination.Country == "USA"
                ? 3m
                : 10m;
        }
    }
}
