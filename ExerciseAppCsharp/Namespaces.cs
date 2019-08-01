using System;
using ProjectA.TeamA;
using PATC = ProjectA.TeamC;

//Part 18 namespace
class Namespaces
{
    public static void Main4()
    {
        //using ProjectA.TeamA
        ClassA.Print();

        //no using
        ProjectA.TeamB.ClassA.Print();

        //using alias (best using)
        PATC.ClassA.Print();
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamC
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team C Print Method");
            }
        }
    }
}