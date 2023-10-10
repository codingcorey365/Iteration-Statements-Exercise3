using System.Reflection.Metadata;
using System.Threading.Channels;
using System.Xml;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        //public static void Print1000()
        //{

        //    for (int i = -1000; i <= 1000; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        // Write a method that will print to the console numbers 3 through 999 by 3 each time
        //public static void ReturnEvery3rdNumber() 
        //{

        //    for (int i = 3; i <= 999; i += 3)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}


        //Write a method to accept two integers as parameterss and check whether they are equal or not
        //public static void IsEqual(int x, int y)
        //{
        //    if(x==y)
        //    {
        //        Console.WriteLine("your numbers equal each other");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Your numbers do not match");
        //    }
        //}


        //Write a method to check whether a given number is even or odd
        //public static void IsEven(int x) 
        //{
        //    if (x % 2 == 0)
        //    {
        //        Console.WriteLine("Your Number is even");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Your number is odd");
        //    }
        //}

        //Write a method to check whether a given number is positive or negative
        //public static void IsPositive(int x)
        //{
        //    if (x > 0)
        //    {
        //        Console.WriteLine("Your Number is even");
        //    }
        //    else if (x < 0)
        //    {
        //        Console.WriteLine("Your number is odd");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your number is Zero");
        //    }
        //}

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //public static void CanVote(string x)
        //{
        //    // throws exceptions to unexpected values
        //    //var newX = int.Parse(x);

        //    //TryParse
        //    if (int.TryParse(x, out var y))
        //    {
        //        if (y >= 18)
        //        {
        //            Console.WriteLine("User can vote");
        //        }
        //        else
        //        {
        //            Console.WriteLine("You are not old enough to vote");
        //        }
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Please enter a valid number");
        //    }

        //    //if (newX >= 18)
        //    //{
        //    //    Console.WriteLine("User can vote");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("You are not old enough to vote");
        //    //}
        //}

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        //public static void InRange(int x)
        //{
        //    if (x >= -10 && x <= 10)
        //    {
        //        Console.WriteLine("Your Number is in range");
        //    }
        //    //else if (x <= 10)
        //    //{
        //    //    Console.WriteLine("Your number is odd");
        //    //}
        //    else
        //    {
        //        Console.WriteLine("Your number is not in range");
        //    }
        //}

        ////Write a method to display the multiplication table(from 1 to 12) of a given integer
        //public static void mulitplyTable(int userInput) 
        //{
        //    int i = 1;
        //    Console.BackgroundColor = ConsoleColor.Green;
        //    Console.ForegroundColor = ConsoleColor.Black;
        //    Console.Clear();
        //    while (i <= 12) 
        //    {
        //        Console.WriteLine(i* userInput);

        //        i++;
        //    }
        //}



//Call the methods to test them in the Main method below
static void Main(string[] args)
        {
    // ReturnEvery3rdNumber();
    // Print1000();
    // IsEqual(0, 0);
    // IsEven(25);
    // IsPositive(5);

    // Console.WriteLine("Please input your age");
    // string input = Console.ReadLine();
    // CanVote(input);

    //Console.WriteLine("write a number that is in the range -10 to 10");
    //var userInput = Convert.ToInt32(Console.ReadLine());
    //InRange(userInput);

    //Console.WriteLine("write a number to multiply in a table");
    //var userInput = Convert.ToInt32(Console.ReadLine());
    //mulitplyTable(userInput);

}
    }
}
