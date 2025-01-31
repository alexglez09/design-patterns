using Command.Commands;

namespace Command
{
    public class Runner
    {
        public void Run(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository, Product product)
        {
            var addToCartCommand = new AddToCartCommand(
                shoppingCartRepository,
                productRepository,
                product);

            var increaseQuantityCommand = new ChangeQuantityCommand(
                shoppingCartRepository,
                productRepository,
                Operation.Increase,
                product);

            var decreaseQuantityCommand = new ChangeQuantityCommand(
                shoppingCartRepository,
                productRepository,
                Operation.Decrease,
                product);

            var manager = new CommandManager();
            manager.Invoke(addToCartCommand);
            manager.Invoke(increaseQuantityCommand);
            manager.Invoke(decreaseQuantityCommand);

            manager.UndoAll();
        }
    }
}
