using System;
using System.Collections.Generic;
using System.Text;

namespace  StoreManagementSystem.Products
{
   public class Category
    {
        public int  CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
         
        public Category (int CategoryID, string CategoryName , string Description) 
        {

        }
    }
}
