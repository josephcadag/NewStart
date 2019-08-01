using System;

class MainClass
{
   static void Main2()
   {
        Console.WriteLine("Enter FirstName");
        string FirstName =  Console.ReadLine();

        Console.WriteLine("Ënter LastName");
        string LastName = Console.ReadLine();

        Console.WriteLine("Welcome {0} {1}", FirstName, LastName);
        //Module();
        //Integer();
        //StringType();
        //Level();
        //Verbatim();
        //Operator();
        //LongTernary();
        //ShortTernary();
        //Nullable();
        //Implicit();
        //Explicit();
        //Parse();
        //TryParse();
        //Arrays();
        //IfStatement();
        //SwitchStatement(); //part 12
        //Coffee(); //part 12
        //WhileLoop(); //part 13
        //DoWhile(); //part 14
        //Coffee2(); //part 14
        //ForEachFor(); //part 15
        BraekContinue(); //part 15
   }

    static void Module()
    {
        Console.WriteLine("Module");
    }

    static void Integer()
    {
        int i = 0;

        Console.WriteLine("MinValue = {0}", int.MinValue);
        Console.WriteLine("MaxValue = {0}", int.MaxValue);
    }

    static void Bool()
    {
        bool b = true;

        b = false;
    }

    static void StringType()
    {
        string Name = "C:\\file\\joseph\\folder\\xamarin";
        Console.WriteLine(Name);
    }

    static void Level()
    {
        string Name = "One\nTwo\nThree";
        Console.WriteLine(Name);
    }

    static void Verbatim()
    {
        string Name = @"C:\file\joseph\folder\xamarin";
        Console.WriteLine(Name);
    }

    static void Operator()
    {
        int NumberOne = 10;
        int NumberTwo = 20;

        if (NumberOne == 10 && NumberTwo == 20)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Wrong");
        }
        if (NumberOne == 10 || NumberTwo == 20)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Wrong");
        }
    }

    static void LongTernary()
    {
        int Number = 10;

        bool IsNumber1;

        if (Number == 10)
        {
            IsNumber1 = true;
        }
        else
        {
            IsNumber1 = false;
        }

        Console.WriteLine("Number == 10 is {0}", IsNumber1);
    }

    static void ShortTernary()
    {
        int Number = 15;

        bool IsNumber1 = Number == 10 ? true : false;

        Console.WriteLine("Number == 10 is {0}", IsNumber1);
    }

    static void Nullable()
    {
        bool? AreyouBoy = null;

        if (AreyouBoy == true)
        {
            Console.WriteLine("The user is boy");
        }
        else if (AreyouBoy == false)
        {
            Console.WriteLine("The user is girl");
        }
        else
        {
            Console.WriteLine("The user has no gender");
        }
    }

    static void Implicit()
    {
        int i = 1000;

        float f = i;

        Console.WriteLine(f);
    }

    static void Explicit()
    {
        float f = 123.45F;

        int i = (int)f;
        //int i = Convert.ToInt32(f);

        Console.WriteLine(i);
    }

    //if the number is in string. use Parse or TryParse
    static void Parse()
    {
        string stringNumber = "100";

        int i = int.Parse(stringNumber);

        Console.WriteLine(i);
    }

    static void TryParse()
    {
        string stringNumber = "143";
        //string stringNumber = "143F";

        int result = 0;

        bool IsConvertionSuccessful = int.TryParse(stringNumber, out result);

        if (IsConvertionSuccessful)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Type invalid number");
        }
    }

    static void Arrays()
    {
        int[] OddNumbers = new int[3];

        OddNumbers[0] = 1;
        OddNumbers[1] = 3;
        OddNumbers[2] = 5;

        Console.WriteLine(OddNumbers[2]);
    }

    static void IfStatement()
    {
        Console.WriteLine("Please enter a number");

        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 1)
        {
            Console.WriteLine("Your number is one");
        }
        else if (UserNumber == 2)
        {
            Console.WriteLine("Your number is two");
        }
        else
        {
            Console.WriteLine("Your choice a wrong number");
        }

        //deffirent between || and |
        /*if (UserNumber == 10 | UserNumber == 20)
        {
            Console.WriteLine("Your number is 10 or 20");
        }
        else
        {
            Console.WriteLine("You enter wrong number");
        }*/

        //deffirent between && and &
        /*if (UserNumber == 10 & UserNumber == 20)
        {
            Console.WriteLine("Your number is 10 or 20");
        }
        else
        {
            Console.WriteLine("You enter wrong number");
        }*/
    }

    static void SwitchStatement()
    {
        Console.WriteLine("Please choice number 1 or 2");

        int UserNumber = int.Parse(Console.ReadLine());

        /*switch (UserNumber)
        {
            case 1:
                Console.WriteLine("You choice number one");
                break;
            case 2:
                Console.WriteLine("You choice number two");
                break;
            default:
                Console.WriteLine("You choice a wrong number");
                break;
        }*/

        //Simple way to do this
        switch (UserNumber)
        {
            case 1:
            case 2:
                Console.WriteLine("You choice number {0}", UserNumber);
                break;
            default:
                Console.WriteLine("You choice a wrong number");
                break;
        }
    }
    //Part 12
    static void Coffee()
    {
        int TotalCost = 0;

        Start:
        Console.WriteLine("Please choice size : 1 - small, 2 - meduim, 3 - large");
        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalCost += 1;
                break;
            case 2:
                TotalCost += 2;
                break;
            case 3:
                TotalCost += 3;
                break;
            default:
                Console.WriteLine("Sorry your choice {0} is invalid", UserChoice);
                goto Start;
        }
        //goto is more complex when debug
        Decide:
        Console.WriteLine("You want to buy another coffee - Yes or No");
        string UserDecision = Console.ReadLine();

        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("You choice {0} is invalid, Please try again...", UserDecision);
                goto Decide;
        }

        Console.WriteLine("Thank you!");
        Console.WriteLine("Total amount = {0}", TotalCost);
    }
    //part 13
    static void WhileLoop()
    {
        Console.WriteLine("Please select target number");
        int UserTarget = int.Parse(Console.ReadLine());

        int Start = 0;

        //never ending 0
        /*while (Start <= UserTarget)
        {
            Console.WriteLine(Start);
        }*/

        //Vertical print out (WriteLine)
        /*while (Start <= UserTarget)
        {
            Console.WriteLine(Start);
            Start = Start + 2;
        }*/

        //Horizontal print out (write)
        while (Start <= UserTarget)
        {
            Console.Write(Start + " ");
            Start = Start + 2;
        }
    }
    //part 14
    static void DoWhile()
    {

        string UserChoice = string.Empty;
        do
        {
            Console.WriteLine("Please select target number");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.Write(Start + " ");
                Start = Start + 2;
            }

            do
            {
                Console.WriteLine("Do you want to continue - Yes or No?");
                UserChoice = Console.ReadLine().ToUpper();
                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Your choice is invalid!");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");
        } while (UserChoice == "YES");
    }
    //part 14
    static void Coffee2()
    {
        int TotalCost = 0;
        string UserDecision = string.Empty;
        do
        {
            int UserChoice = -1;
            do
            {
                Console.WriteLine("Please choice size : 1 - small, 2 - meduim, 3 - large");
                UserChoice = int.Parse(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1:
                        TotalCost += 1;
                        break;
                    case 2:
                        TotalCost += 2;
                        break;
                    case 3:
                        TotalCost += 3;
                        break;
                    default:
                        Console.WriteLine("Sorry your choice {0} is invalid", UserChoice);
                        break;
                }
            } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

            do
            {
                Console.WriteLine("You want to buy another coffee - Yes or No");
                UserDecision = Console.ReadLine().ToUpper();

                if (UserDecision != "YES" && UserDecision != "NO")
                {
                    Console.WriteLine("You choice {0} is invalid, Please try again...", UserDecision);
                }
            } while (UserDecision != "YES" && UserDecision != "NO");
        } while (UserDecision.ToUpper() != "NO");

        Console.WriteLine("Thank you!");
        Console.WriteLine("Total amount = {0}", TotalCost);
    }
    //part 15 it can read different type of storage like int, string...
    static void ForEachFor()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 1;
        Numbers[1] = 2;
        Numbers[2] = 3;

        //foreach
        foreach (int k in Numbers)
        {
            Console.WriteLine(k);
        }

        //for
        for (int j = 0; j < Numbers.Length; j++)
        {
            Console.WriteLine(Numbers[j]);
        }

        //while
        int i = 0;
        while (i < Numbers.Length)
        {
            Console.WriteLine(Numbers[i]);
            i++;
        }
    }
    //part 15
    static void BraekContinue()
    {
        //print even number up to 20
        //for (int i = 0; i <= 20; i = i+2)
        //continue
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 1)
                continue;

            Console.Write(i);
        }
        //break
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);

            if (i == 10)
                break;
        }
    }
}
