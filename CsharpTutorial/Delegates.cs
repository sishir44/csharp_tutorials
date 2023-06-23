using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    /* delegates */
    delegate int SumDel(int x, int y);
    class Delegates
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static void PrintSum(int a, int b, SumDel delHandler)
        {
            Console.WriteLine($"Sum of {a} and {b} is {delHandler(a,b)}");
        }
        static void Main(string[] args)
        {
            /* using callback mechanism */
            SumDel sumHandler = Sum;
            PrintSum(4, 6, sumHandler);

            /* Using Anonymous methods */
            SumDel sumHandler1 = delegate (int a, int b)
            {
                return (a + b);
            };
            PrintSum(5, 10, sumHandler1);

            /* Using Lamda Function */
            SumDel sumHandler2 = (a,b) => { 
                return (a + b); 
            };
            PrintSum(10, 10, sumHandler2);


        }
    }
}
