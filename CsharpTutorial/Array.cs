using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpTutorial
{
    class Array
    {
        public static void Main(string[] args)
        {
            /* One way to create Array */
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }

            /* Second way to create Array and merger and sort it */
            int[] arr1 = { 16,45,67,9,89,12,43,32 };
            int[] arr2 = { 150,600,4,5,2,1 };
            int[] mergearr = arr1.Concat(arr2).ToArray();
            for(int i=0; i< mergearr.Length; i++)
            {
                Console.Write($"{mergearr[i]} ");
            }
            Console.WriteLine("After Sorting an Array");
            //Array.Sort(mergearr);
            for (int i = 0; i < mergearr.Length; i++)
            {
                Console.Write($"{mergearr[i]} ");
            }

            /* Second way to create Array String */
            string[] name = { "ccr", "bohara", "HaRRY", "jOHN", "Anders Hejlsberg" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"{name[i]} ");
            }
        }
    }
}
