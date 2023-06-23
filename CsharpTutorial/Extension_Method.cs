using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public static class Extension
    {
        /* Extension Method */
        public static int MyCount(this string s)
        {
            return s.Length;
        }
    } 
    class Extension_Method
    {
        static void Main(string[] args)
        {
            string str = "Sishir"; //this is existing type
            Console.WriteLine(str.MyCount()); // adding MyCount in existing method
        }
    }
}
