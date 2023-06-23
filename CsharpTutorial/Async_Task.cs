using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Async_Task
    {
        /* using normal method*/
        public static int PrintA()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"A{i}");                
            }
            Thread.Sleep(5000);
            return 1;
        }

        /* using async method */
        public static async Task<int> PrintB()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"A{i}");
            }
            await Task.Delay(5000);
            return 1;
        }

        public static async Task Main()
        {
            /* call a normal method */
            int taskA = PrintA();
            Console.WriteLine("I am outside from task A");
            Console.WriteLine("I am also outside from task A");
            Console.WriteLine($"Result of task A is {taskA}");

            /* call a async method */
            Task<int> taskB = PrintB();
            Console.WriteLine("I am outside from task B");
            Console.WriteLine("I am also outside from task B");
            await taskB;
            Console.WriteLine($"Result of task A is {taskB.Result}");
        }
    }
}
