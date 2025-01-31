namespace Strategy.Shipping
{
    public interface IShippingCostService
    {
        decimal CalculateShippingCost(Order order);
    }

    public class ShippingCostService : IShippingCostService
    {
        readonly IShippingCostStrategy shippingCostStrategy;

        public ShippingCostService(IShippingCostStrategy shippingCostStrategy)
        {
            this.shippingCostStrategy = shippingCostStrategy;
        }

        public decimal CalculateShippingCost(Order order)
        {
            return this.shippingCostStrategy.Calculate(order);
        }
    }
}
