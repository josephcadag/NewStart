using System;

//Part 19 Classes
class Costumer
{
    string _firstName;
    string _lastName;

    //Constructor
    //has no return type
    public Costumer(string FirstName, string LastName)
    {
        //much readable way
        this._firstName = FirstName;

        //not much readable
        _lastName = LastName;
    }

    //Constructor
    //may use default Constructor like this
    public Costumer() : this("There no FirstName Provided", "There no LastName Provided")
    {

    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstName + " " + _lastName);
    }

    //Destructor
    ~Costumer()
    {
        
    }
}


class Classes
{
    public static void Main5()
    {
        //Less constructor or default
        Costumer costumer1 = new Costumer();
        costumer1.PrintFullName();

        Costumer costumer2 = new Costumer("Joseph", "Cadag");
        costumer2.PrintFullName();
    }
}
