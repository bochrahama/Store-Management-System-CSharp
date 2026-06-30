namespace StoreManagementSystem.Products{
    public enum TypeCoffee
    {
        Espresso,
        Latte,
        Cappuccino,
        Americano,
        Macchiato       
    }
    public enum Size
    {
        Small , Medium , Large
    }
    public enum CaffeineLevel
    {
        High , Medium , Low
    }
    public class Coffee : Product
    {
        public  TypeCoffee type {get; set;}
        public Size Size {get ; set ;}
        public CaffeineLevel CaffeineLevel {get ; set ;}
        public bool isIced {get ; set;}

        public Coffee (int productId ,  TypeCoffee type , decimal price , int quantity,
                    Size size , CaffeineLevel caffeineLevel ,bool isIced )
                    : base (productId ,type.ToString() , price , quantity )
        {
            this.Size = size ;
            this.CaffeineLevel = caffeineLevel ; 
            this.isIced = isIced ;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Size : {Size} - Caffein :{CaffeineLevel}";
        }
        string PreparDrink()
       {
            if (isIced)
                return "is iced ";
            return "is hot";
       }
    }

}
