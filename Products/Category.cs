using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace  StoreManagementSystem.Products
{
   public class Category
    {
        public int  CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        
        private List<Product> _products = new List<Product>();
        public Category (int CategoryID, string CategoryName , string Description) 
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.Description = Description;
        }
        public void AddProduct(Product product)
        {
            if (product!= null && _products.Contains(product))
            
               _products.Add(product); 
        }
         public List<Product> GetProductsCategory(){
                return new List<Product>(_products);
            }
    }
}

