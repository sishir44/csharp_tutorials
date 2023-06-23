using System;
using System.Collections;

namespace CsharpTutorial
{
    internal class Non_Generic_Collection
    {
        static void Main(string[] args)
        {
            /* Non-Generic Collection ArrayList */
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("s");
            arrayList.Add('r');
            arrayList.Add(true);
            arrayList.Add(null);
            arrayList.Add(6.7);
            int[] num = { 2, 3, 4, 5 };
            string[] name = { "rachan", "sishir" };
            arrayList.AddRange(num);
            arrayList.AddRange(name);
            arrayList.Insert(1, "Bohara"); // insert Bohara at position 1
            arrayList.InsertRange(2, name); // keep name array at 2nd position
            arrayList.Remove(5); // remove the value
            arrayList.RemoveAt(3); // remove an array at 3rd position
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            /* Non-Generic Collection Hashtable */
            Hashtable ht = new Hashtable();
            ht.Add(1, "ccr"); // key,value
            ht.Add("1", 'c');
            ht.Add(1.2, 'c');
            ht.Add(true, "Don");
            ht.Add(false, 100);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Key: {item.Key}, Value:{item.Value}");
            }
            Console.WriteLine(ht.Contains(1)); //return T/F and takes only key
            Console.WriteLine(ht.ContainsValue("Don")); //return T/F and takes only value

        }
    }
}
