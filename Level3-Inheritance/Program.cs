// Inheritance – Traits from the Ancestors
// Inheritance lets one class absorb features of another. Like how a Dog inherits from Animal, but also barks. 🐶

// 📜 Concept:
// Create a base class with common properties/methods.
// Derive a child class that inherits the base and adds its own twist.
// Reduces redundancy, makes code DRY.

namespace Level3_Inheritance
{
    public class Animal
    {
        public string? Name { get; set; }
        public virtual void Speak()
        {
            Console.WriteLine("This Animal Makes a Sound");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!!");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Meow!!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { Name = "Doggy Buddy" };
            dog.Speak();
            Cat cat = new Cat { Name = "Catty catt !!" };
            cat.Speak();
            Animal generic = new Animal { Name = "Creature" };
            generic.Speak();
        }
    }
}