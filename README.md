# learn-oops-in-csharp
A hands-on project to master OOP concepts in C# with real code examples.





# 🧠 Smart Employee Management System (OOP Console App)

This is a clean, beginner-friendly console application in C# that demonstrates **all four pillars of Object-Oriented Programming (OOP)**:  
**Encapsulation, Inheritance, Polymorphism, and Abstraction** — with a real-world example of managing employees in an organization.

---

## 🚀 Features

- 🔒 **Encapsulation**: Private fields with public properties
- 🧬 **Inheritance**: Base `Employee` class extended by `Developer` and `Manager`
- 🎭 **Polymorphism**: Each employee type calculates salary differently
- 🔧 **Abstraction**: Abstract base class + Interface (`ILogActivity`)
- 🖥️ Clean and testable **console output**

---

## 🏗️ Project Structure

```bash
BossLevel-EmployeeApp/
├── Program.cs            # Main logic and execution
├── Employee.cs           # Abstract class with shared behavior
├── Developer.cs          # Child class
├── Manager.cs            # Child class
├── ILogActivity.cs       # Interface for logging activity
