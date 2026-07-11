using StoreManagementSystem.Employees;
public class Finance
{
    public decimal balance { get; set; }
    public List<FinanceRecord> financeRecords { get; set; }

    public Finance(decimal initialBalance)
    {
        balance = initialBalance;
        financeRecords = new List<FinanceRecord>();
    }
    // Method to add money to the balance and create a finance record
    public decimal Addmoney(decimal amount, string description)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "ERROR: The amount must be greater than 0.");
        balance += amount;
        financeRecords.Add(new FinanceRecord(financeRecords.Count + 1, amount, DateTime.Now, description));
        return balance;
    }
    public decimal RemoveMoney(decimal amount, string description)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "ERROR: The amount must be greater than 0.");
        if (amount > balance)
            throw new InvalidOperationException("ERROR: Insufficient funds.");
        balance -= amount;
        financeRecords.Add(new FinanceRecord(financeRecords.Count + 1, -amount, DateTime.Now, description));
        return balance;
    }
    public decimal PaySalary(Employee employee)
    {
        if (employee == null)
            throw new ArgumentNullException(nameof(employee), "ERROR: The employee cannot be null.");
        if (employee.Salary <= 0)
            throw new ArgumentOutOfRangeException(nameof(employee.Salary), "ERROR: The salary must be greater than 0.");
        if (employee.Salary > balance)
            throw new InvalidOperationException("ERROR: Insufficient funds to pay the salary.");
        balance -= employee.Salary;
        financeRecords.Add(new FinanceRecord(financeRecords.Count + 1, -employee.Salary, DateTime.Now, $"Salary payment for {employee.Name}"));
        return balance;
    }
    public decimal CalculateRevenue()
    {
        return financeRecords.Where(record => record.Amount > 0).Sum(record => record.Amount);
    }
    public decimal CalculateExpenses()
    {
        return financeRecords.Where(record => record.Amount < 0).Sum(record => record.Amount);
    }
    public decimal CalculateProfit()
    {
        return CalculateRevenue() + CalculateExpenses();
    }
    public override string ToString()
    {
        return $@"Finance Summary:Calculate Revenue: {CalculateRevenue():C},Calculate Expenses: {CalculateExpenses():C},Calculate Profit: {CalculateProfit():C},Current Balance: {balance:C}";
    }
    }