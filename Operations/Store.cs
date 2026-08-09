using System;

using StoreManagementSystem.Employees;
using StoreManagementSystem.Products;

namespace StoreManagementSystem.Operations
{
    public class Store
    {
        private string v;

        public Store(string v)
        {
            this.v = v;
        }

        public string StoreName { get; set; }
        public required Inventory Inventory { get; set; }
        public required Finance Finance { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();       
        public List<Sale> Sales { get; set; } = new List<Sale>();


        public void RunMenu()
        {
            Console.WriteLine($"Welcome to {StoreName}!");
            Console.WriteLine("1. Manage Inventory");
            Console.WriteLine("2. Manage Employees");
            Console.WriteLine("3. Manage Sales");
            Console.WriteLine("4. View Financial Reports");
            Console.WriteLine("5. Exit");
        }
        public void AddProduct(Product product)
        {
            Inventory.Products.Add(product);
        }
        public void HireEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void ProcessSale(Sale sale)
        {
            Sales.Add(sale);

        }
        public Report GenerateReport()
        {
            Console.WriteLine($"Financial Report for {StoreName}:");

            var totalRevenue = Finance?.CalculateRevenue() ?? 0m;
            var totalExpenses = Finance?.CalculateExpenses() ?? 0m;

            Console.WriteLine($"Total Revenue: {totalRevenue:C}");
            Console.WriteLine($"Total Expenses: {totalExpenses:C}");
          

            var report = new Report
            {
                ReportDescription = $"Financial Report for {StoreName}",
                TotalRevenue = totalRevenue,
                TotalExpenses = totalExpenses,
                TotalProfit = totalRevenue - totalExpenses
            };

            return report;
        }

    }
}