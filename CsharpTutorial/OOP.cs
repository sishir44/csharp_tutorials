using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;

namespace CsharpTutorial
{
    // Create Class
    public class Car
    {
        // fields or Data Member
        public string make;
        public string model;
        public string color;
        public int year;
        public int price;

        // Methods
        public void Start()
        {
            Console.WriteLine("Car is started.");
        }
        public void Stop()
        {
            Console.WriteLine("Car is Stopped.");
        }
        public void Run()
        {
            Console.WriteLine("Car is running.");
        }
    }

    public class OOP
    {
        static void Main(string[] args)
        {
            Car obj = new Car();

            obj.make = "xyz";
            obj.model = "model123";
            obj.color = "red";
            obj.year = 5; 
            obj.price = 1000000;
            Console.WriteLine($"make:{obj.make} model:{obj.model} color: {obj.color} year:{obj.year} price:{obj.price}");

            obj.Start();
            obj.Stop();
            obj.Run();

            // How to use Namespace from Create_Namespace.cs (School is namespace)
            Student student = new Student();
            student.Display();
            Teacher teacher  = new Teacher();
            teacher.Display();
            Department department = new Department();
            department.Display();
        }
    }
}
