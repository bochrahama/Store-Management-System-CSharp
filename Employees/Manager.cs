namespace StoreManagementSystem.Employees
{
    public class Manager : Employee
    {
        public string Department { get; set; }
        public Manager(int employeeId, string name, string position, decimal salary, DateTime hireDate, EmployeeRole role, string department )
            : base(employeeId, name, position , salary , hireDate , role )
        {
            this.Department = department;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Department: {Department}";
        }
    }
}