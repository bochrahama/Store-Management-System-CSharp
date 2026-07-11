public enum FinanceRecordType
{
    Income,
    Expense
}
public class FinanceRecord
{
    public int RecordId { get; set; } // The unique ID of the finance record
    public decimal Amount { get; set; } // The amount of the transaction
    public FinanceRecordType RecordType => Amount >= 0 ? FinanceRecordType.Income : FinanceRecordType.Expense; // The type of the transaction (Income or Expense)
    public DateTime TransactionDate { get; set; } // The date and time of the transaction
    public string Description { get; set; } // A description of the transaction
    public FinanceRecord(int recordId, decimal amount, DateTime transactionDate, string description)
    {
        RecordId = recordId;
        Amount = amount;
        TransactionDate = transactionDate;
        Description = description;
    }
}