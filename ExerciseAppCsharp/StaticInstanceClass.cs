using System;

//part 20 static and stance method
//you cannot use static if you use name is like class name
//example
/*class Circle
{
    public static Circle()
    {
        //cannot use like this.
    }
}*/
//by default if there no access modifier it is private

class Circle
{
    //use of static method
    static float _PI;

    //if you wish to access the static constructor use public
    //public static float _PI;

    //instance
    //float _PI = 3.1416F;

    //instance method if there no static
    int _Raduis;

    //static is first before instance
    //it can't be public access modifier
    //static it call once
    static Circle()
    {
        //to check
        Console.WriteLine("Static constructor");
        Circle._PI = 3.1416F;
    }

    //instance modifier
    public Circle(int Raduis)
    {
        //to check
        Console.WriteLine("Insance constructor Raduis = {0}", Raduis);
        this._Raduis = Raduis;
    }

    public float CalculateArea()
    {
        //use of static method
        return Circle._PI * this._Raduis * this._Raduis;

        //use instance method
        //return this._PI * this._Raduis * this._Raduis;
    }
}

class StaticInstanceClass
{
    public static void Main6()
    {
        Circle circle1 = new Circle(7);
        float Area1 = circle1.CalculateArea();
        Console.WriteLine("Area = {0}", Area1);

        Circle circle2 = new Circle(10);
        float Area2 = circle2.CalculateArea();
        Console.WriteLine("Area = {0}", Area2);

        Circle circle3 = new Circle(5);
        float Area3 = circle3.CalculateArea();
        Console.WriteLine("Area = {0}", Area3);

        //try to access the static constructor use public in constructor
        //Console.WriteLine(Circle._PI);
    }
}

