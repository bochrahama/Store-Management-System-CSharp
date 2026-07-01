using System.Reflection.PortableExecutable;
using StoreManagementSystem;
using StoreManagementSystem.Products;


Coffee cof = new Coffee(4, TypeCoffee.Espresso, 30.4m, 4, Size.Small, CaffeineLevel.Medium, true);
Console.WriteLine(cof);


Tea tea = new Tea(5, TypeTea.Green, 30.4m, 4, 3, true);
Console.WriteLine(tea);

Cake cake = new Cake(3,CaKeType.ChocolateCake ,20.4m ,4 , CakeSize.Medium  );
Console.WriteLine(cake);

Juice juice = new Juice(6 , TypeJuice.MixedFruit , 23.3m ,2 ,true );
Console.WriteLine(juice);

//Completing the Juice class: variables with validations + methods.