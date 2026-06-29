using System.Data.Common;

public enum ProductCategory
{
    coffe , tea , juice , MilKshake , Cack 
}

public abstract class Products
{
    public int ProductId {set; get;}
    public string Name {get; set; }
    private decimal Price ;
    private int Quantity ;

    //Encapsulation with price and Quantity 
    public decimal Price
    {
        set
        {
            if (value <= 0)
                throw new ArgumentException("ERROR : the price should be greaten than 0");
            _price = value ;
        }
        get  {return _price ; }
    }
    public int Quantity
    {
        set
        {
            if (value <0)
                throw new ArgumentException("ERROR : the Quantity should be greaten than 0");
            _quantity = value ;
        }
        get  {return _quantity ;}
    }
    //constructer 
    public Products(int productId , string name , decimal price , int quantity)
    {
        if (productId <= 0)
        {
            throw new ArgumentException("the Id prducts should be greaten than 0");
        }
        this.ProductIdv = productId ;
        this.Name = name ;
        this.Price = Price ;
        this.Quantity = quantity;
    }

    public abstract void DisplayInfo();
    public void ApplyDiscount(double percentage)
    {
        if(percentage<0 || percentage > 100)
        {
            throw new ArgumentException ("ERROR : the porsontage they should be between 0 and 100");
        }
        decimal priceAmoint = this.Price * (decimale)(percentage/100 );
        this.Price = this.Price - priceAmoint;
    }
    public bool isInStock()
    {
        if (this.Quantity > 0)
           return true ;
        return false ;
    }
}