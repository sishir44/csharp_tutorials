using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpTutorial
{
    /* 1.Create a class employee with name, salary, dateOfJoining attributes,a method getEmployeeDetails(). 
       Name,salary and date of joining will bet set from constructor.*/
    public class Employee //class
    {
        public string name;
        public double salary;
        public DateTime doj;

        public void GetEmployeeDetails()
        {
            Console.WriteLine($"Name: {name}, Salary:{salary}, DOJ:{doj}");
        }

        public Employee(string sname, double ssalary, DateTime sdoj) // parametarized constructor
        {
            name = sname;
            salary = ssalary;
            doj = sdoj;
        }
    }

    /* 2.Create a class that contains Add(),sub(), mul(),div() methods,those method should return a desired value.*/
    public class Calculation  // class
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Div(int x, int y)
        {
            return x / y;
        }

        /* 3.Create a method that checks number is even or odd.*/
        public string CheckEvenOdd(int num)  // methods
        {
            if(num%2==0)           
                return "This is even";          
            else          
                return "This is Odd";         
        }
    }

    class Exercise_3
    {
        static void Main(string[] args)
        {
            //Object for class 1
            Employee obj = new Employee("Sishir", 20000, DateTime.Now);
            obj.GetEmployeeDetails();

            //Object for class 2
            Calculation obj2 = new Calculation();
            int x = 10; int y = 5;
            int sum = obj2.Add(x, y);
            int sub = obj2.Sub(x, y);
            int mul = obj2.Mul(x, y);
            int div = obj2.Div(x, y);
            Console.WriteLine($"sum of {x} and {y} is: {sum}");
            Console.WriteLine($"sub of {x} and {y} is: {sub}");
            Console.WriteLine($"mul of {x} and {y} is: {mul}");
            Console.WriteLine($"div of {x} and {y} is: {div}");
            //for point no 3
            Console.WriteLine(obj2.CheckEvenOdd(3));


        }
}
}
