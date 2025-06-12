
// Project: Smart Employee Management System

// ✅ We'll Apply:
// Pillar	How
// Class & Object -	    Create Employee objects
// Encapsulation -	    Use private fields + public properties
// Inheritance -	    Developer and Manager inherit Employee
// Polymorphism -	    CalculateSalary() overridden in child classes
// Abstraction -	    Abstract base class + Interface for ILogActivity


using System;
using System.Collections.Generic;

// Interface: Behavior every employee has
public interface ILogActivity
{
    void LogWork();
}

// Abstract base class
public abstract class Employee : ILogActivity
{
    private string _name;
    private int _id;

    public string Name 
    { 
        get => _name; 
        set => _name = value; 
    }

    public int ID 
    { 
        get => _id; 
        set => _id = value; 
    }

    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public abstract double CalculateSalary();
    public abstract void DisplayRole();

    public void LogWork()
    {
        Console.WriteLine($"{Name} is logging today's work.");
    }
}

// Inherited class - Developer
public class Developer : Employee
{
    public int LinesOfCode { get; set; }

    public Developer(string name, int id, int lines) : base(name, id)
    {
        LinesOfCode = lines;
    }

    public override double CalculateSalary()
    {
        return 30000 + LinesOfCode * 0.5;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} (ID: {ID}) is a Developer.");
    }
}

// Inherited class - Manager
public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, int id, int teamSize) : base(name, id)
    {
        TeamSize = teamSize;
    }

    public override double CalculateSalary()
    {
        return 50000 + TeamSize * 1000;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} (ID: {ID}) is a Manager.");
    }
}

// Program Entry
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Developer("Piyush", 101, 1200),
            new Manager("Neha", 102, 5)
        };

        foreach (var emp in employees)
        {
            emp.DisplayRole();
            emp.LogWork();
            Console.WriteLine($"Salary: ₹{emp.CalculateSalary()}\n");
        }
    }
}
