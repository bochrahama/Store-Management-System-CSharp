using System.Reflection.PortableExecutable;
using StoreManagementSystem.Products;


Coffee cof = new Coffee(4, TypeCoffee.Espresso, 30.4m, 4, Size.Small, CaffeineLevel.Medium, true);
Console.WriteLine(cof);


Tea tea = new Tea(5, TypeTea.Green, 30.4m, 4, 3, true);
Console.WriteLine(tea);