
public enum EmployeeRole
{
    Manager, Cashier, Barista, Cleaner, DeliveryEmployee, Assistant
}
public abstract class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }
    public EmployeeRole Role { get;protected set; }
    public Employee(int employeeId, string name, string position, decimal salary, DateTime hireDate, EmployeeRole role)
    {
        this.EmployeeId = employeeId;
        this.Name = name;
        this.Position = position;
        this.Salary = salary;
        this.HireDate = hireDate;
        this.Role = role;
    }
    public abstract void DisplayInfo();
    public virtual decimal CalculatePaid() { return Salary; }
}