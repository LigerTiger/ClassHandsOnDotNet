using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    class Product
    {
        //variables
        public int productId;
        public string productName;
        public string description;
        public double price;
        //method
        public void Details()
        {
            // to show product details
            Console.WriteLine("Id: " + productId);
            Console.WriteLine("Name: " + productName);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Price: " + price);
        }
    }
    class Test_Product
    {
        static void Main()
        {
            Product p1 = new Product();
            p1.productId = 324093;
            p1.productName = "Keyboard";
            p1.description = "Computer accessories";
            p1.price = 800;
            p1.Details(); //call the method
          
            Product p2 = new Product();
            p2.productId = 443443;
            p2.productName = "Wireless Speakers";
            p2.description = "Music systems";
            p2.price = 12000;
            p2.Details();
            Console.ReadKey();


        }
    }
}
