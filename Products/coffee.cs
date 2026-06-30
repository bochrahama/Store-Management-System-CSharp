namespace StoreManagementSystem.Products{
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
        public Size Size {get ; set ;}
        public CaffeineLevel CaffeineLevel {get ; set ;}
        public bool isIced {get ; set;}

        public Coffee (int productId ,  string name , decimal price , int quantity,
                    Size size , CaffeineLevel caffeineLevel ,bool isIced )
                    : base (productId ,name , price , quantity )
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
