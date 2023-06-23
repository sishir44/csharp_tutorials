using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public enum Weeks
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };
    class Enums
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Weeks.Friday);
            Console.WriteLine((int)Weeks.Friday);
        }
    }
}
