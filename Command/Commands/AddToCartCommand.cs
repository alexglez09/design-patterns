namespace Command.Commands
{
    public class AddToCartCommand : ICommand
    {
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;
        private readonly Product product;

        public AddToCartCommand(
            IShoppingCartRepository shoppingCartRepository,
            IProductRepository productRepository,
            Product product)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
            this.product = product;
        }

        public void Execute()
        {
            this.productRepository.DecreaseStock(this.product.ProductId);
            this.shoppingCartRepository.Add(this.product);
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Undo()
        {
            this.productRepository.IncreaseStock(this.product.ProductId);
            this.shoppingCartRepository.Remove(this.product);
        }
    }
}
