using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    /*Creating Method Overriding*/
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Doing Drawing Shape");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Doing Drawing Circle");
        }
    }
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Doing Drawing Square");
        }
    }
    /*End of Method Overriding*/
    internal class Polymorphism
    {
        /* Creating Method Overloading */
        public void Sum(int a, int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        public void Sum(int a, int b, int c)
        {
            Console.WriteLine($"Sum is {a + b + c}");
        }
        /* End of Method Overloading */

        static void Main()
        {
            /* Method Overloading */
            Polymorphism obj = new Polymorphism();  
            obj.Sum(1,2);
            obj.Sum(1, 2, 3);

            /* Method Overriding */
            Shape shape = new Shape();
            shape.Draw();
            Shape circle = new Circle();
            circle.Draw();
            Shape square = new Square();
            square.Draw();


        }
    }
}
