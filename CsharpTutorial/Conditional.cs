using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Conditional
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            Console.Write("Enter a number: ");  // same line
            int x = Convert.ToInt32(Console.ReadLine());
            if(x < 6)
            {
                Console.WriteLine("Numbers are less than 6");
            }
            else if(x == 6)
            {
                Console.WriteLine("Number is 6");
            }
            else
            {
                Console.WriteLine("Numbers are greater than 6");

            }
        }
    }
}
