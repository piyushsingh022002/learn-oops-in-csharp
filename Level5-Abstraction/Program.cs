// Abstraction – The Hidden Engine
//Abstraction hides how things work and only shows what they do — like driving a car without needing to know how the engine works.


// 📜 Concept:
// Abstract classes: Can’t be instantiated. Used as a blueprint.

// Interfaces: 100% abstract — only method declarations.

// You force child classes to implement only what's necessary.

// 1. Abstract Class (Vehicle):
// A partial blueprint.

// Has abstract methods → child must implement them.

// Can have normal methods too.

// 2. Concrete Class (Car, Bike):
// Inherit from Vehicle

// Must provide their own version of Start() and Stop()

// 3. Interface (IMaintainable):
// 100% abstract (only method declarations)

// Any class that implements it must define those methods.

// 4. Car implements both:
// Inherits from Vehicle

// Implements IMaintainable
// ✅ Real-World Analogy:
// Abstract class = Vehicle blueprint (every vehicle must have start and stop)

// Interface = Extra responsibility (like “Can be serviced”)

// Concrete class = Actual working product (Car or Bike)


using System;

namespace Level5_Abstraction
{
    // Interface
    public interface IMaintainable
    {
        void Service();
    }

    // Abstract class
    public abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Stop();

        public void FuelType()
        {
            Console.WriteLine("Generic Fuel");
        }
    }

    public class Car : Vehicle, IMaintainable
    {
        public override void Start()
        {
            Console.WriteLine("Car engine started with a key.");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stopped with brake pedal.");
        }

        public void Service()
        {
            Console.WriteLine("Car servicing in progress...");
        }
    }

    public class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike started with kick.");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike stopped with handle brake.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car();
            myCar.Start();
            myCar.FuelType();
            myCar.Stop();

            IMaintainable maintainableCar = new Car();
            maintainableCar.Service();

            Console.WriteLine();

            Vehicle myBike = new Bike();
            myBike.Start();
            myBike.FuelType();
            myBike.Stop();
        }
    }
}

