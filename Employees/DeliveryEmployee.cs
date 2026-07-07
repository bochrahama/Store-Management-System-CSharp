namespace StoreManagementSystem.Employees
{
    public class DeliveryEmployee : Employee
    {
        public DeliveryEmployee(int employeeId, string name, string position, decimal salary, DateTime hireDate )
            : base(employeeId, name, position, salary, hireDate, EmployeeRole.DeliveryEmployee)
        {
           
        }

        public string ProcessDelivery()
        {
            return $"Delivery Employee {Name} is processing a delivery.";
        }

    }
}