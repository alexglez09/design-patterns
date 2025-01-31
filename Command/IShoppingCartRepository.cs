namespace Command;

public interface IShoppingCartRepository
{
    void Add(Product product);
    
    void Remove(Product product);
    
    void DecreaseQuantity(int productProductId);
    
    void IncreaseQuantity(int productProductId);
}