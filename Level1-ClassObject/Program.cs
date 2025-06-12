using System;
namespace Level1_ClassObject
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hii i am {Name}. My age is {Age}!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Piyush Singh";
            p1.Age = 22;
            p1.Introduce();

            Person p2 = new Person { Name = "Piyush Singh 2", Age = 23 };
            p2.Introduce();
        }
    }
}