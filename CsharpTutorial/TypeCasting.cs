using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class TypeCasting
    {
        static void Main(string[] args)
        {
            /*Implicit Conversion ☟ */
            int a = 5;
            double d = a; 
            long l = a; 
            Console.WriteLine(d);


            /*Explicit Conversion ☟ */
            double d1 = 1234.53456;
            int a1 = (int)d1; 
            Console.WriteLine(a1);

        }
    }
}
