namespace Command.Commands
{
    public class ChangeQuantityCommand : ICommand
    {
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;
        private readonly Operation operation;
        private readonly Product product;

        public ChangeQuantityCommand(
            IShoppingCartRepository shoppingCartRepository,
            IProductRepository productRepository,
            Operation operation,
            Product product)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
            this.operation = operation;
            this.product = product;
        }

        public void Execute()
        {
            switch (operation)
            {
                case Operation.Decrease:
                    this.productRepository.IncreaseStock(this.product.ProductId);
                    this.shoppingCartRepository.DecreaseQuantity(this.product.ProductId);
                    break;
                case Operation.Increase:
                    this.productRepository.DecreaseStock(this.product.ProductId);
                    this.shoppingCartRepository.IncreaseQuantity(this.product.ProductId);
                    break;
            }
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Undo()
        {
            switch (this.operation)
            {
                case Operation.Decrease:
                    this.productRepository.DecreaseStock(this.product.ProductId);
                    this.shoppingCartRepository.IncreaseQuantity(this.product.ProductId);
                    break;
                case Operation.Increase:
                    this.productRepository.IncreaseStock(this.product.ProductId);
                    this.shoppingCartRepository.DecreaseQuantity(this.product.ProductId);
                    break;
            }
        }
    }
}
