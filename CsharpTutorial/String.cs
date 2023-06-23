using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class String
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            string str = @"
                I
                am
                Sishir";
            IEnumerable<char> newStr = s.Concat(str);
            foreach (char c in newStr)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine($"The length of {s} is: {s.Length}"); // length of string = 5
            Console.WriteLine(s[0]); // first letter
            int len = s.Length;
            Console.WriteLine(s[len-1]); // last letter
        }
    }
}
