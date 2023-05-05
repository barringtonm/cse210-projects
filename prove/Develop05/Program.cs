using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        Console.Write("Please enter your name?   ");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number:  42 ");
         string userInput = Console.ReadLine();
         var a = int.Parse(userInput);

          var square = a *a;
          

        Console.WriteLine($" {name}, the square number is {square} ");





    }
}