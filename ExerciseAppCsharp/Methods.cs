using System;

class Methods
{
    //part 17 array parameter
    public static void Main3()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 1;
        Numbers[1] = 2;
        Numbers[2] = 3;

        //no passing array
        //ParamsMethod();

        ParamsMethod(Numbers);

        //Multiple array
        //ParamsMethod(1, 2, 3, 4, 5);
    }

    public static void ParamsMethod(params int[] Numbers)
    {
        Console.WriteLine("There are {0} elements", Numbers.Length);

        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }

    //part 17 output parameter show two or more value
    /*public static void Main()
    {
        int SumTotal = 0;
        int ProductTotal = 0;

        Calculate(10, 20, out SumTotal, out ProductTotal);

        Console.WriteLine("SumTotal = {0} & ProductTotal = {1}", SumTotal, ProductTotal);
    }

    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
        Product = FN * SN;
    }*/

    //part 17
    /*public static void Main()
    {
        int i = 10;
        //passing by value
        //SimpleMethod(i);

        //passing by reference 
        SimpleMethod(ref i);

        Console.WriteLine(i);
    }
    //passing by value
    //public static void SimpleMethod(int j)

    //passing by reference
    public static void SimpleMethod(ref int j)
    {
        j = 100;
    }*/

    //part 16
    /*public static void Main()
    {
        //if the EvenNumbers is not static
        //Methods m = new Methods();
        //m.EvenNumbers();

        //if the EvenNumbers is static
        //Methods.EvenNumbers();
        Methods.EvenNumbers(10); //using Target number

        Methods m = new Methods();
        int Sum = m.Add(10, 20);

        Console.WriteLine("Sum = {0}", Sum);
    }

    public int Add(int FN, int SN)
    {
        return FN + SN;
    }

    //public void EvenNumbers() //not static
    //public static void EvenNumbers() //static
    public static void EvenNumbers(int Target) //using Target number
    {
        int Start = 0;

        while (Start <= Target)
        {
            Console.WriteLine(Start);
            Start = Start + 2;
        }
    }*/
}
