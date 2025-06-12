using System;
using System.Collections.Generic;

namespace Level4_Polymorphism
{
    // Run-time Polymorphism
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle.");
        }
    }

    // Compile-time Polymorphism
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Run-time Polymorphism Demo
            List<Shape> shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle(),
                new Triangle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw(); // All call same method, different results
            }

            // Compile-time Polymorphism Demo
            Calculator calc = new Calculator();
            Console.WriteLine($"Add(int, int): {calc.Add(2, 3)}");
            Console.WriteLine($"Add(double, double): {calc.Add(2.5, 3.7)}");
            Console.WriteLine($"Add(int, int, int): {calc.Add(1, 2, 3)}");
        }
    }
}
