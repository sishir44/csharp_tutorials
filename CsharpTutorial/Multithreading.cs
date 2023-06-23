using System;
using System.Threading;

namespace CsharpTutorial
{
    class Multithreading
    {
        static void Print1()
        {
            for(int i = 1; i < 4; i++) 
            {
                Console.WriteLine("Method1-"+ i);
                if(i == 2)
                {
                    Thread.Sleep(3000);
                }
            }
        }
        static void Print2()
        {
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Method2-" + i);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Print1));
            Thread thread2 = new Thread(new ThreadStart(Print2));
            thread1.Start();
            thread2.Start();
        }
    }
}
