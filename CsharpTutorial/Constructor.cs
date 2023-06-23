using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    // Create Class
    public class Person
    {
        // data member
        public string name;
        public int age;

        // create Constructor: it has same name as Class and doesn't contain any return type
        public Person()
        {
            Console.WriteLine("Constructor Called!");
        }
        // Parametarized Constructor
        public Person(string Sname, int Sage)
        {
            name = Sname; age = Sage;
        }
        public void DisplayPerson()
        {
            Console.WriteLine($"name: {name}, age: {age}");
        }
    }
    class Constructor
    {
        static void Main(string[] args)
        {
            Person obj = new Person("sishir", 23);
            obj.DisplayPerson();
            Person obj2 = new Person();
            obj.DisplayPerson();
        }
    }
}
