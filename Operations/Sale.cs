using StoreManagementSystem.Products;   
public class Sale
{
    public int SaleId { get; set; }// The unique ID of the sale
    public List<Product> products{ get; set; }// The list of products sold in the sale
    public decimal TotalAmount { get; set; }// The total amount of the sale
    
    public DateTime SaleDate { get; set; }// The date and time when the sale was made
    int EmployeeId { get; set; } // The ID of the employee who processed the sale
    public Sale(int saleId, DateTime saleDate,  int employeeId)
    {
        SaleId = saleId;
        SaleDate = DateTime.Now;
        products = new List<Product>();
        EmployeeId = employeeId;
    }

    public decimal CalculateTotalAmount(decimal price, int quantity)
    {
        return price * quantity;
    }
    public void AddProduct(Product product, int quantity)
    { 
        if (product == null)// Check if the product is null
            throw new ArgumentNullException(nameof(product), "ERROR: The product cannot be null.");
        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity), "ERROR: The quantity must be greater than 0.");
        if (product.Quantity < quantity)// Check if there is enough stock for the product
            throw new InvalidOperationException($"ERROR: Not enough stock for product {product.Name}. Available: {product.Quantity}, Requested: {quantity}.");

        for (int i = 0; i < quantity; i++)
        {
            products.Add(product);
        }

        TotalAmount += CalculateTotalAmount(product.Price, quantity);
        product.RemoveStock(quantity);
    }
    
    public override string ToString()
    {
        return $@"   Sale ID: {SaleId} ,
    the peoducts sold: {string.Join(", ", products.Select(p => p.Name))},
    Total Amount: {TotalAmount:C},  
    Sale Date: {SaleDate}, 
    Employee ID: {EmployeeId}";
    }
}