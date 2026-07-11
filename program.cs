using System.Reflection.PortableExecutable;
using StoreManagementSystem;
using StoreManagementSystem.Products;
using StoreManagementSystem.Employees;

Category category1 = new Category(1, "Caffee", "Drinks and refreshments");
Category category2 = new Category(2, "cake", "Sweet treats and baked goods");
Category category3 = new Category(3, "juice", "Freshly squeezed fruit and vegetable juices");
Category category4 = new Category(4, "milkshake", "Creamy and indulgent milkshakes");
Category category5 = new Category(5, "tea", "A variety of teas from around the world");

Coffee cof = new Coffee(4, TypeCoffee.Espresso, 30.4m, 4, Size.Small, CaffeineLevel.Medium, true, category1);
Console.WriteLine(cof);


Tea tea = new Tea(5, TypeTea.Green, 30.4m, 4, 3, true, category1);  
Console.WriteLine(tea);

Cake cake = new Cake(3, CaKeType.ChocolateCake, 20.4m, 4, CakeSize.Medium , category2);
Console.WriteLine(cake);

Juice juice = new Juice(6, TypeJuice.MixedFruit, 23.3m, 2, true , category3);
Console.WriteLine(juice);

MilKShake milKShake = new MilKShake(8, MilkshakeType.Caramel, 33.4m, 1, false, category4);
Console.WriteLine(milKShake);

Manager employee = new Manager(4, "John", "manager", 4000.0m, new DateTime(2024, 5, 1), EmployeeRole.Manager , "cake");
Console.WriteLine(employee);


//Completing the Sale class: This class represents a sale made in the store.