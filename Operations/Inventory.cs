

using StoreManagementSystem.Products;
public class Inventory
{
  public List<Product> Products { get; set; }
  public int LowStockThreshold { get; set; }

 public Inventory(int lowStockThreshold)
    {
        Products = new List<Product>();
        LowStockThreshold = lowStockThreshold;
    }

   public void  IncresesStoke (Product prod, int Quantity)
    {
        if (Quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(Quantity), "ERROR: The stock to increase must be greater than 0.");

        prod.InsertStock(Quantity);
    }
    public void DecreasesStoke(Product prod, int Quantity)
    {
        if (
            Quantity<= 0)
            throw new ArgumentOutOfRangeException(nameof(Quantity), "ERROR: The stock to decrease must be greater than 0.");
        prod.RemoveStock(Quantity);
    }
    public void CheckLowStock()
    {
        foreach (var product in Products)
        {
            if (product.Quantity <LowStockThreshold)
            {
                Console.WriteLine($"Low stock alert: {product.Name} (ID: {product.ProductId}) has only {product.Quantity} items left.");
            }
        }
    }
    public bool IsOutOfStock(Product prod)
    {
        if (!prod.isInStock())
            return true;
        return false;
    }
}