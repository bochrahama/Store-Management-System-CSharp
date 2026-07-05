using StoreManagementSystem.Products;

namespace StoreManagementSystem
{
    public enum CaKeType
    {
       ChocolateCake, Cheesecake, RedVelvet, Tiramisu, OreoCake, CarrotCake 
    }
    public enum CakeSize
    {
         Small , Medium , Large
    }
    public class Cake : Product
    {
        public CaKeType cakeType {get ; set; }
        public CakeSize cakeSize {get; set;}

        public Cake (int productId , CaKeType caKeType , decimal price , int quantity , CakeSize cakeSize , Category category)
        :base(productId , caKeType.ToString() , price , quantity , category)
        {
            this.cakeSize = cakeSize;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Size : {cakeSize}";
        }
    }
}