# Complete-Inheritance-Example
#### Employee Management System to show inheritance 

This C# project implements an Employee Management System with a hierarchy of classes, including Employee, Manager, Sales, Maintenance, and Developer.

## Table of Contents

- [Introduction](#introduction)
- [Classes](#classes)
- [Usage](#usage)
- [Examples](#examples)


## Introduction

The Employee Management System is designed to manage different types of employees within an organization. It utilizes a class hierarchy where the base class `Employee` contains common attributes such as `id`, `name`, `minimumHours`, and `wage`. Subclasses like `Manager`, `Sales`, `Maintenance`, and `Developer` inherit these common attributes and provide specific functionality for calculating basic and total salaries.

## Classes

### Employee

The base class representing an employee with the following attributes:

- `Id`: Employee ID
- `Name`: Employee name
- `MinimumHours`: Minimum working hours
- `Wage`: Hourly wage rate

### Manager

Subclass of `Employee`. It includes additional attributes and methods specific to managers.

### Sales

Subclass of `Employee`. It includes additional attributes and methods specific to sales employees.

### Maintenance

Subclass of `Employee`. It includes additional attributes and methods specific to maintenance employees.

### Developer

Subclass of `Employee`. It includes additional attributes and methods specific to developers.

## Usage

You can use these classes to create and manage employees in your C# application. Here's a basic example of how to use them:
in program.cs 
```csharp
using System;

class Program
{
    static void Main()
    {
        Manager manager = new Manager(1000, "Hany", 176, 10);
        Sales sales = new Sales(1001, "Hany", 180, 9, 0.05m, 10000m);
        Maintenance maintenance = new Maintenance(1002, "Hany Main", 176, 9);
        Developer developer = new Developer(1003, "Hany", 180, 14, true);

        Employee[] employees = { manager, sales, maintenance, developer };

        foreach (Employee employee in employees)
        {
            Console.WriteLine("*--*--**--*-*-*-*-*-*-*-*-*-**--**");
            Console.WriteLine(employee.GetType().ToString().Replace("Csharp.", ""));
            Console.WriteLine(employee);
        }
    }
}

