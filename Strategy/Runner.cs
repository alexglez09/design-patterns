using Strategy.Shipping;
using Strategy.Shipping.Strategies;

namespace Strategy
{
    public class Runner
    {
        public Result Run(Order order)
        {
            IShippingCostService fedExShippingCostService = new ShippingCostService(new FedExShippingCostStrategy());
            var fedExShippingCost = fedExShippingCostService.CalculateShippingCost(order);

            IShippingCostService upsShippingCostService = new ShippingCostService(new UpsShippingCostStrategy());
            var upsShippingCost = upsShippingCostService.CalculateShippingCost(order);

            return new Result
            {
                FedExShippingCost = fedExShippingCost,
                UpsShippingCost = upsShippingCost
            };
        }
    }
}