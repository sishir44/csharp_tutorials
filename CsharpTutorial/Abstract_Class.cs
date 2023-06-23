using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public abstract class Employeee1
    {
        double salary;
        public double GetMinSalary()
        {
            return salary;
        }
        public abstract double CalculateBonus();
    }
    abstract class Shape1
    {
        int x;
        public abstract void Draw1();
        public abstract void Draw2();
        public void Print()
        {
            Console.WriteLine("Printing.....");
        }
    }
    internal class Abstract_Class : Shape1
    {
        public override void Draw1()
        {
            Console.WriteLine("This is drawing 1");
        }
        public override void Draw2()
        {
            Console.WriteLine("This is drawing 2");
        }
        static void Main(string[] args)
        {
            Abstract_Class obj = new Abstract_Class();
            obj.Print();
            obj.Draw1();
            obj.Draw2();
        }
    }
}
