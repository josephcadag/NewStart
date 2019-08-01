using System;

//part 23
//polymorphism - enable us to invoke derived class method
//using a base class reference variable at runtime
public class Employee
{
    public string FirstName ="FN";
    public string LastName = "LN";

    //using the override method
    //in base use virtual
    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class PartTimeEmployee : Employee
{
    //use override method
    // two way to use override
    //public override void PrintFullName()
    //{
    //    base.PrintFullName();
    //}
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Part Time");
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
    }
}

public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Temporary");
    }
}

class Polymorphism
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];

        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporaryEmployee();

        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
    }
}

