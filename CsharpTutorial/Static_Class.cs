using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class Static_Class
    {
        static int count = 0;
        public Static_Class()
        {
            count++;
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public void Print()
        {
            Console.WriteLine(count);
        }
        static void Main()
        {
            Console.WriteLine(Static_Class.Sum(5, 7)); // accessing static method

            Static_Class o = new Static_Class();
            o.Print();
            Static_Class o1 = new Static_Class();
            o1.Print();
            Static_Class o2 = new Static_Class();
            o2.Print();
            Static_Class o3 = new Static_Class();
            o3.Print();
        }
    }
}
