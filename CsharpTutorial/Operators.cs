using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Operators
    {
        public static void Main(string[] args)
        {
            /* Arithmetic Operator */
            int a = 20;
            int b = 10;
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            int mod = a % b; // module operator, gives remainder as result
            int preincr = ++a; // pre increment by 1
            int predecr = --a; // pre decrement by 1

            /* Relational Operator, (boolean type) */
            bool cNum = a == b; // compare whether a equal to b or not result as true or false

            /* Logical Operator, (boolean type) */
            bool dNum = a == 20 && b == 10; 
            bool doNum = a == 20 || b == 0;

            /* Assignment Operator */
            a += 5; // 20 + 5 = 25 as result
            b *= 2; // 10 * 2 = 20
        }
    }
}
