public class Sale
{
    public int SaleId { get; set; }// The unique ID of the sale
    public int ProductId { get; set; }// The ID of the product sold in this sale
    public decimal TotalAmount { get; set; }// The total amount of the sale
    public int QuantitySold { get; set; }// The quantity of the product sold in this sale
    public DateTime SaleDate { get; set; }// The date and time when the sale was made
    int EmployeeId { get; set; } // The ID of the employee who processed the sale
    public Sale(int saleId,int productId, decimal totalAmount, DateTime saleDate, int quantitySold , int employeeId)
    {
        SaleId = saleId;
        ProductId = productId;
        TotalAmount = totalAmount;
        SaleDate = saleDate;
        QuantitySold = quantitySold;
        EmployeeId = employeeId;
    }

    public decimal CalculateTotalAmount(decimal price, int quantity)
    {
        return price * quantity;
    }
    public override string ToString()
    {
        return $@"   Sale ID: {SaleId} ,
    Product ID: {ProductId}, 
    Total Amount: {TotalAmount:C},  
    Quantity Sold: {QuantitySold}, 
    Sale Date: {SaleDate}, 
    Employee ID: {EmployeeId}";
    }
}