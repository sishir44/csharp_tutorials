using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
    internal class Properties
    {
        static void Main()
        {
            Product product = new Product();
            product.Name = "Macbook Pro";
            product.Price = -150000;
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
        }
    }
}
