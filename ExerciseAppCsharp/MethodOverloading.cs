using System;

//Part 25
//Method overloading allow a class have a same name, but with different signature
//overloaded can based on number, type(int, float, etc) and kind(value, ref or out) of parameters
//Signature of a method consists of namenof the method and the type, kind and numbers
//signature method does not include return type and param modifier
class MethodOverloading
{
    public static void Main9()
    {
        //Add()
    }

    //type parameters
    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    public static void Add(int FN, int SN, float TN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    public static void Add(int FN, int SN, int TN, int ON)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    public static void Add(float FN, int SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    //kind parameters
    public static void Add(int FN, int SN, out int Sum)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
        Sum = FN + SN;
    }

    //connot do this
    //based on return type
    //public static void Add(int FN, int SN, int TN)
    //{
    //    Console.WriteLine("Sum = {0}", FN + SN + TN);
    //}

    //public static int Add(int FN, int SN, int TN)
    //{
    //    Console.WriteLine("Sum = {0}", FN + SN + TN);
    //    return FN + SN + TN;
    //}

    //also this one cannot do this
    //based on params modifier
    //public static void Add(int FN, int SN, params int[] TN)
    //{
    //    Console.WriteLine("Sum = {0}", FN + SN);
    //}

    //public static void Add(int FN, int SN, int[] TN)
    //{
    //    Console.WriteLine("Sum = {0}", FN + SN);
    //}
}
