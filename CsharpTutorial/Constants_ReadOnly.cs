using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Constants_ReadOnly
    {
        readonly int x = 15; //initially readonly variable declare

        public Constants_ReadOnly() // Create Constructor for the class
        {
            x = 20;
        }
        static void Main(string[] args)
        {
            // Constants ☟ 
            const int a = 5;  // can not change value of a after initialize
            //a = 10; getting arror
            Console.WriteLine(a);

            Constants_ReadOnly o = new Constants_ReadOnly(); // Object create for class
            // o.x = 20; error
            Console.WriteLine(o.x);
        }
    }
}
