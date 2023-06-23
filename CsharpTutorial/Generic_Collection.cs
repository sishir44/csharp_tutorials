using System;
using System.Collections.Generic;

namespace CsharpTutorial
{
    internal class Generic_Collection
    {
        static void Main(string[] args)
        {
            /* Generic Collection List<T> : List<int> */
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("there");
            list.Add("everyone");
            list.Add("........");
            list[3] = "How are you!"; // update a value at index 4th posiotion but we can't add
            list.RemoveAt(1); // remove a element at position 1
            list.Remove("there"); // remove a value           
            list.Clear(); // clear all the list array
            Console.WriteLine(list[1]); // return a value at position at 1
            Console.WriteLine(list.Contains("Hello")); // return bool value
            Console.WriteLine(list.Find(a => a.ToLower().Contains("eve"))); // lamda function
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            /* Generic Collection Dictionary<k,v> : Dictionary<int,string> */
            Dictionary<int, string> obj = new Dictionary<int, string>();
            obj.Add(1, "John");
            obj.Add(2, "Harry");
            obj.Add(3, "Max");
            obj.Add(4, "Jerry");
            obj.Add(5, "Marry");
            obj.Add(6, "Erry");
            obj.Remove(1); // remove a value havine key = 1
            obj.Clear(); // clear a data
            var itemHarry = new KeyValuePair<int, string>(2, "Harry");
            Console.WriteLine(obj.Contains(itemHarry)); // return a true if value is contain
            foreach (KeyValuePair<int, string> kvp in obj)
            {
                Console.WriteLine($"Key:{kvp.Key} and Value:{kvp.Value}");
            }


            /* Generic Collection HashSet<T> : HashSet<int> */
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(1);
            set.Add(3);
            set.Add(3);
            set.Add(2);
            set.Add(2);
            set.Add(5);
            set.Add(5);
            set.Add(4);
            set.Remove(2); // remove all the 2 element
            set.Remove(1); // remove all 1 element
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }





        }
    }
}
