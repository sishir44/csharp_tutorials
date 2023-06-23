using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class MyProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Array1
    {
        public static void Main(string[] args)
        {
            MyProduct[] products =
            {
                new MyProduct{Name="Product 1", Price=1000},
                new MyProduct{Name="Product 2", Price=1500},
                new MyProduct{Name="Product 3", Price=2000}
            };
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} {product.Price}");
            }
        }
    }
}
