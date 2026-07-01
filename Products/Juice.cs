using System.Reflection.Metadata;

namespace StoreManagementSystem.Products
{
    public enum TypeJuice
    {
        Orange, Apple, Mango, Strawberry, Pineapple, MixedFruit
    }
    public class Juice : Product
    {
        public TypeJuice typeJuice {get ; set;}
        public bool isFreshlySqueezed {get; set;}

        public Juice (int productId , TypeJuice typeJuice , decimal price , int quantity , bool isFreshlySqueezed)
        :base(productId , typeJuice.ToString() , price , quantity)
        {
            this.isFreshlySqueezed = isFreshlySqueezed ;
        }

        public string IsFreshlySqueezed()
        {
            if (isFreshlySqueezed)
              return "the juice is fresh";
            return "the juice is pre-pachaged";
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Is Fresh?: {IsFreshlySqueezed()}";
        }
    }
}