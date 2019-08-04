using System;

//Part 30
//it contains decleration only no implementation
//by default it's public
//can't have fields
interface ICostumer
{
    void Print();
}

interface ICommand : ICostumer
{
    void Command();
}

//classes can inherit multiple interface
//while classes can't inherit multiple class
public class Costumers : ICommand
{
    public void Print()
    {
        Console.WriteLine("Print interface");
    }

    public void Command()
    {
        Console.WriteLine("This is command");
    }
}

public class Interfaces
{
    public static void Main12()
    {
        Costumers C1 = new Costumers();
        C1.Print();
        C1.Command();

        //also can do this one
        ICostumer C2 = new Costumers();
        C2.Print();
    }
}
