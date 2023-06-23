using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Exceptional
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 6;
                int b = 0;
                Console.WriteLine(a/b);
                Console.WriteLine("Try Block........");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Catch Block.....");
            }
            finally
            {
                Console.WriteLine("this is finally block");
            }
            Console.WriteLine("Divided Successfully...");
        }
    }
}
