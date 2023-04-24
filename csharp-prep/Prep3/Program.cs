using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number == 6 ?");
        Console.WriteLine("What is your guess?   ");
        string userInput = Console.ReadLine();
        int number =int.Parse(userInput);

        if (number  == 4)
        {
            Console.WriteLine("Higher");
        }

        else if ( number == 7)
        {
            Console.WriteLine("Lower");
        }

        else if ( number == 6)
        {
            Console.WriteLine("You guess it");
        }

        else
        {
            Console.WriteLine("Guess again");
        }

    }
}
























