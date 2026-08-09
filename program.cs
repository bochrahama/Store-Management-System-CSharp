using StoreManagementSystem;
using StoreManagementSystem.Employees;
using StoreManagementSystem.Operations;
using StoreManagementSystem.Products;

//program.cs class for the Store Management System to demonstrate the functionality of the store management system, including product management, inventory tracking, employee management, sales processing, and financial reporting.
partial class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("   STORE MANAGEMENT SYSTEM");


        try
        {
            // 1) Categories
            Category coffeeCategory = new Category(1, "Coffee", "Drinks and refreshments");
            Category cakeCategory = new Category(2, "Cake", "Sweet treats and baked goods");
            Category juiceCategory = new Category(3, "Juice", "Freshly squeezed fruit and vegetable juices");
            Category milkshakeCategory = new Category(4, "Milkshake", "Creamy and indulgent milkshakes");
            Category teaCategory = new Category(5, "Tea", "A variety of teas from around the world");

            // 2) Products
            Coffee coffee = new Coffee(1, TypeCoffee.Espresso, 30.4m, 10, Size.Small, CaffeineLevel.Medium, true, coffeeCategory);
            Tea tea = new Tea(2, TypeTea.Green, 25.0m, 15, 3, true, teaCategory);
            Cake cake = new Cake(3, CaKeType.ChocolateCake, 20.4m, 8, CakeSize.Medium, cakeCategory);
            Juice juice = new Juice(4, TypeJuice.MixedFruit, 23.3m, 12, true, juiceCategory);
            MilKShake milkshake = new MilKShake(5, MilkshakeType.Caramel, 33.4m, 6, false, milkshakeCategory);

            Console.WriteLine("---- Products ----");
            Console.WriteLine(coffee);
            Console.WriteLine(tea);
            Console.WriteLine(cake);
            Console.WriteLine(juice);
            Console.WriteLine(milkshake);
            Console.WriteLine();
            // 3) Inventory
 
            Inventory inventory = new Inventory(lowStockThreshold: 5);
            inventory.Products.Add(coffee);
            inventory.Products.Add(tea);
            inventory.Products.Add(cake);
            inventory.Products.Add(juice);
            inventory.Products.Add(milkshake);


            // 4) Finance
   
            Finance finance = new Finance(initialBalance: 1000m);

            Store store = new Store("The Coffee Corner")
            {
                StoreName = "The Coffee Corner",
                Inventory = inventory,
                Finance = finance
            };

            // 6) Employees

            Manager manager = new Manager(1, "John", "Store Manager", 4000.0m, new DateTime(2024, 5, 1), EmployeeRole.Manager, "Management");
            Cashier cashier = new Cashier(2, "Sara", "Cashier", 2200.0m, new DateTime(2024, 8, 1), registerId: 1);
            DeliveryEmployee deliveryEmployee = new DeliveryEmployee(3, "Karim", "Delivery", 2000.0m, new DateTime(2025, 1, 10));

            store.HireEmployee(manager);
            store.HireEmployee(cashier);
            store.HireEmployee(deliveryEmployee);

            Console.WriteLine("---- Employees ----");
            foreach (Employee employee in store.Employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();
            // 7) Process a sale

            Sale sale = new Sale(saleId: 1, saleDate: DateTime.Now, employeeId: cashier.EmployeeId);
            sale.AddProduct(coffee, 2);
            sale.AddProduct(cake, 1);
            store.ProcessSale(sale);

            Console.WriteLine("---- Sale ----");
            Console.WriteLine(sale);
            Console.WriteLine();

            // Record the sale income and pay the delivery employee's salary
            finance.Addmoney(sale.TotalAmount, $"Revenue from Sale #{sale.SaleId}");
            finance.PaySalary(deliveryEmployee);

            // ---------------------------------------------------------
            // 8) Inventory check
            // ---------------------------------------------------------
            Console.WriteLine("---- Low Stock Check ----");
            inventory.CheckLowStock();
            Console.WriteLine();

            // ---------------------------------------------------------
            // 9) Financial report
            // ---------------------------------------------------------
            Console.WriteLine("---- Financial Report ----");
            Report report = store.GenerateReport();
            Console.WriteLine(report.ReportDescription);
            Console.WriteLine($"Total Revenue : {report.TotalRevenue:C}");
            Console.WriteLine($"Total Expenses: {report.TotalExpenses:C}");
            Console.WriteLine($"Total Profit  : {report.TotalProfit:C}");
            Console.WriteLine();


            // 10) Store menu

            store.RunMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}   
