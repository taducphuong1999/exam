using System;
using ConsoleApp1.entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new  Product[];
            var productname = "";
            for (int i = 0; i < 5; i++)
            {
                if(i < 3) {
                    // products[i]
                    products[i] = new Book();
                    productname = string.Format("Product {0}", i+1);
                    products[i] = new Book();
                    products[i]._name = productname;
                    products[i]._id = i;
                    products[i]._price = 2500;
                    Console.WriteLine("Book: (id={0},name='{1}',price={2}) - computeTax = {3}", products[i]._id, products[i]._name, products[i]._price, products[i].computeTax());
                }
                else {

                    products[i] = new Phone();
                    productname = string.Format("Product {0}", i+1);
                    products[i]._name = productname;
                    products[i]._id = i;
                    products[i]._price = 5000;
                    Console.WriteLine("Phone: (id={0},name='{1}',price={2}) - computeTax = {3}", products[i]._id, products[i]._name, products[i]._price, products[i].computeTax());

                }
            }
        }
    }
}