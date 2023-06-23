using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Fruit
    {
        /* Indexer */
        private string[] names = new string[10];
        public string this [int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
    }
    class Indexer
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            fruit[0] = "Apple";
            fruit[1] = "Mango";
            fruit[2] = "Banana";
            fruit[3] = "Kiwi";
            fruit[4] = "Gragon";

            for(var i=0; i<5; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
    }
}
