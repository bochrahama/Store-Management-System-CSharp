namespace StoreManagementSystem.Products
{
    public enum TypeTea
    {
        Green, Black, Mint, Lemon, Peach, Chamomile
    }
    public class Tea : Product
    {
        public TypeTea type {get; set;}
        public int SteepTimeMinutes {set; get;}
        public bool isHerbal {set; get;}

        public Tea (int productId ,  TypeTea type , decimal price , int quantity,
                    int SteepTimeMinutes , bool isHerbal)
                    : base (productId ,type.ToString() , price , quantity )
        {
            this.type = type;
            this.SteepTimeMinutes = SteepTimeMinutes;
            this.isHerbal = isHerbal;
        }     

        public override string ToString()
        {
            return $"{base.ToString()} -long that take :{SteepTimeMinutes} - isHerbal : {isHerbal}";
        }
    }
}