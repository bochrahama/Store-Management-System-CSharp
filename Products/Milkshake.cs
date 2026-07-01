namespace StoreManagementSystem.Products
{
    public enum MilkshakeType
    {
        Vanilla, Chocolate, Oreo, Banana, Strawberry, Caramel
    }
    public class MilKShake : Product
    {
        public MilKShake milKShake {get; set;}
        public bool HasWhippedCream {get; set;}

        public MilKShake(int productId , MilkshakeType milkshakeType , decimal price , int quantity , bool HasWhippedCream)
        :base(productId , milkshakeType.ToString() , price , quantity)
        {
            this.HasWhippedCream = HasWhippedCream ;
        }

        public string hasWhippedCream()
        {
            if (HasWhippedCream)
                return "with cream";
            return "without cream ";
        }

        public override string ToString()
        {
            return $"{base.ToString()} - with cream? : {hasWhippedCream()}"; 
        }
    }
}