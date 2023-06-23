using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Switch
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 0:
                    Console.WriteLine("Number is 0");
                    break;

                case 1:
                    Console.WriteLine("Number is 1");
                    break;

                case 2:
                    Console.WriteLine("Number is 2");
                    break;

                case 3:
                    Console.WriteLine("Number is 3");
                    break;

                case 4:
                    Console.WriteLine("Number is 4");
                    break;

                case 5:
                    Console.WriteLine("Number is 5");
                    break;

                default:
                    Console.WriteLine("Number is greater than 5");
                    break;
            }

        }
    }
}
