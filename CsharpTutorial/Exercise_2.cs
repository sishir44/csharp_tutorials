using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Exercise_2
    {
        static void Main(string[] args)
        {
            /* 1.Print this pattern
                *
                **
                ***
                ****
                *****
            */
            for (int i = 1;  i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            /* 2.Check the number is even or odd */
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($" is even number");
            }
            else
            {
                Console.WriteLine($" is odd number");
            }

        }
    }
}
