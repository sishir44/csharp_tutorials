using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Jump_Statements
    {
        static void Main(string[] args)
        {
            /* break */
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i); // 1 2
            }


            /* continue */
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i); // 1 2 4 5
            }


            /* goto */
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    goto find;
                }
                Console.WriteLine(i);
            }
            find:
            Console.WriteLine("Jumped out of the for loop"); // 1 2 Jumped...
        }
    }
}
