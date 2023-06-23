using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Loops
    {
        static void Main(string[] args)
        {
            /* While Loop*/
            int x = 1;
            while (x <= 5)
            {
                Console.WriteLine(x);
                x++;
            }


            /* Do While Loop */
            int y = 6;
            do {
                Console.WriteLine(y);
                y++;
            }
            while (y <= 5);


            /* For Loop */
            for (int i = 7; i <= 15; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
