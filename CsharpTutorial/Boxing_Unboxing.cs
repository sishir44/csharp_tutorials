using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class Boxing_Unboxing
    {
        static void Main(string[] args)
        {
            /* Boxing */
            int a = 5;
            Object obj = a;
            Console.WriteLine(obj);

            /* Unboxing */
            int b = (int)a;
            Console.WriteLine(b);

        }
    }
}
