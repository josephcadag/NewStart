using System;

//Object Oriented Programming
//part 21 Inheritance
//one of the primary pilar of OOP
//it allows the code to reuse that ruduce errors and time
//support single baseclass inheritance
//can support multi level class(ex. in class A)
/*public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

//FullTimeEmployee is Derived class
//Employee is Base class
public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

//example of multi level derived class
//all the properties of PartTimeEmployee and Employee class can be access by class A
public class A : PartTimeEmployee
{

}

class Inheritance
{
    public static void Main()
    {
        A a1 = new A();
        a1.FirstName = "A";
        a1.LastName = "Class";
        a1.PrintFullName();
        a1.HourlyRate = 100;

        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "joseph";
        FTE.LastName = "cadag";
        FTE.PrintFullName();
        FTE.YearlySalary = 10000;

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "jeff";
        PTE.LastName = "cadag";
        PTE.PrintFullName();
    }

}*/

/*public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parentclass Constructor was called");
    }

    // example of Constructor overloading
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    //this is to show how to use of controlling constructor overloading
    //public ChildClass() : base("Derived class controlling ParentClass")

    //by default of no constructor overloading
    public ChildClass()
    {
        Console.WriteLine("ChildClass Constructor was called");
    }
}

class Inheritance
{
    public static void Main()
    {
        ChildClass childClass = new ChildClass();
    }
}*/

//Part 21 Method hidding
//two way to call again the base class method
//use base keyword
//use type cast
/*public class Employee
{
    public string FirstName;
    public string LastName;

    //this method will be hide
    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class PartTimeEmployee : Employee
{
    //this is use hidding a method from base class
    //use new if intentionanl hiding
    public new void PrintFullName()
    {
        //using base keyword to call again the base class method
        //base.PrintFullName();

        Console.WriteLine(FirstName + " " + LastName + " - Contractual" );
    }
}

public class FullTimeEmployee : Employee
{

}

class Inheritance
{
    public static void Main7()
    {
        //remind this cannot to this give you an error
        //parentcalss cannot fullfill the resposibility of ChildClass
        //PartTimeEmployee PTE = new Employee();

        //another use of type cast
        Employee PTE = new PartTimeEmployee();

        //PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "PartTime";
        PTE.LastName = "Employee";
        PTE.PrintFullName();

        //using Type cast
        //((Employee)PTE).PrintFullName();

        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FullTime";
        FTE.LastName = "Employee";
        FTE.PrintFullName();
    }

}*/
