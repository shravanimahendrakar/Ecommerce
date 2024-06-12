using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal class Product
    {
        //Attributes with its setter and getter  
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public int Stock { get; set; }

        //constructor of Product class
        public Product(int productId, string productName, double price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        //Method for increase stock
        public void IncreaseStock(int amt)
        {
            if (amt < 0)
                throw new ArgumentException("Amount to increase cannot be negative.");

            Stock += amt;
        }

        //Method for decrease stock
        public void DecreaseStock(int amt)
        {
            if (Stock >= amt)
                Stock -= amt;
            else
                throw new ArgumentException("Insufficient stock to decrease.");
        }
    }
}
