using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public interface A
    {
        public void Display();
    }
    public interface B
    {
        public void Display();
    }
    public interface ICategory
    {
        public bool Add();
        public void Display();
        public void Print();
    }
    public class IC : A,B,ICategory
    {
        public bool Add()
        {
            Console.WriteLine("Adding.......");
            return true;
        }

        public void Display()
        {
            Console.WriteLine("Loading........");
        }
        public void Print()
        {
            Console.WriteLine("Printing-----");
        }
    }
    class Interface
    {
        public static void Main()
        {
            ICategory obj = new IC();
            obj.Add();
            obj.Display();
            obj.Print();
        }
    }
}
