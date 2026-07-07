namespace StoreManagementSystem.Employees
{
    public class Cashier : Employee
    {
        int RegisterId { get; set; }
        public Cashier(int employeeId, string name, string position, decimal salary, DateTime hireDate, int registerId)
            : base(employeeId, name, position, salary, hireDate, EmployeeRole.DeliveryEmployee)
        {
            RegisterId = registerId;
        }

        //after build Sale class, implement the ProcessSale method to process a sale and return a Sale object.
        // public Sale ProcessSale()
        // public void IssueReceipt()

    }
}