using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Generic_Delegates
    {   /* Action<T1> */
        public static void Action(string message, Action<string> greetHandler)
        {
            greetHandler(message);
        }

        /* Func<T1,T2> */
        public static void Func(int a, int b, Func<int,int,int> delHandler)
        {
            Console.WriteLine($"Sum of {a} and {b} is {delHandler(a, b)}");
        }

        /* Predicate<T1,T2> */
        public static void Predicate(int num, Predicate<int> compareHandler) 
        {
            Console.WriteLine(compareHandler(num));
        }
        static void Main(string[] args)
        {
            /* Action<T1> */
            Action<string> greetHandler = (message) =>
            {
                Console.WriteLine(message);
            };
            Action("Welcome to My CSharp", greetHandler);

            /* Func<T1,T2> */
            Func<int, int, int> sumHandler= (a, b) =>
            {
                return a + b;
            };
            Func(4, 6, sumHandler);

            /* Predicate<T1,T2> */
            Predicate(2, a => a < 6); // using lamda function
            Predicate<int> compareHandler = (num) =>
            {
                return num > 10;
            };
            Predicate(5, compareHandler);
        }
    }
}
