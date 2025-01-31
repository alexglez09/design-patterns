namespace Command;

public interface IProductRepository
{
    void DecreaseStock(int productProductId);
    void IncreaseStock(int productProductId);
}