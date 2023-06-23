using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancTutorials
{
    // Base Class or Parent Class
    public class Employee
    {
        public int id;
        public string name;
        public Employee() {} // default constructor
        public Employee(int id, string name)  // parametarize constructor
        {
            this.id = id;
            this.name = name;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine($"Id is {id} and Name is {name}");
        }
    }  // class


    // Derived Class or Child Class
    public class Programmer : Employee  // Inherit from Employee class
    {
        public Programmer(int id, string name):base(id,name)
        {
            
        }
        // mothod
        public void GetCoffee()
        {
            Console.WriteLine("I love to drink Coffee!");
        }
    }


    // Derived Class or Child Class
    public class Manager : Employee // Inherit a class from Employee
    {
        public Manager(int id, string name):base(id, name)
        {
            
        }
        public void AssignTask()
        {
            Console.WriteLine("Assigning a task!");
        }
    }
    class Inheritance
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(4,"Sihsir");
            emp.DisplayEmployee();
            Programmer prg = new Programmer(5, "brs");
            prg.DisplayEmployee();
            prg.GetCoffee();
            Manager mgr = new Manager(6, "rch");
            mgr.DisplayEmployee();
            mgr.AssignTask();

        }
    }
}
