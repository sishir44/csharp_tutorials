using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            /* 1.Enter the 3 inputs and multiply them. Eg: a=5,b=4,c=6, d=5*4*6 */
            int a, b, c, d;
            a=2; b=3; c=4;
            d = a * b * c;
            Console.WriteLine($"Multiplication of {a},{b},{c} is: {d}");

            /* 2.Enter the 2 numbers, print their average */
            double a1 =2; double b1 = 3;
            double e;
            e = (a1 + b1)/2;
            Console.WriteLine($"Average of {a1},{b1} is: {e}");

            /* 3.If someone enters negative value then show the error message “We do not accept negative value”. */
            Console.Write("Enter any number: ");
            int num = Convert.ToInt32( Console.ReadLine());
            if( num < 0 )
            {
                Console.WriteLine($"{num} is not accepted!");
            }

            /* 4.Print two stars ** 4 times */
            for( int i = 1; i < 5; i++ )
            {
                Console.WriteLine("**");
            }

            /* 5. Find the number of characters in “JOHN DOE” */
            string str = "JOHN DOE";
            Console.WriteLine(str.Length);

            /* 6. Print numbers from 1 to 10 except 6  (o/p  1 2 3 4 5 7 8 9 10) */
            for( int i = 1; i <= 10; i++ )
            {
                if(i == 6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
