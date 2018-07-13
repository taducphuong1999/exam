using System;

namespace ConsoleApp1.entity
{
    public class Product
    {
        public int _id { get; set; }
        public  string _name { get; set; }
        public  decimal _price { get; set; }

        public Product()
        {
            
            
        }

        public Product(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public abstract Double computeTax();
    }
    
}