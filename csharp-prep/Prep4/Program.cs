using System;

class Program
{
    static void Main(string[] args)
   
    {
        Random randomGenarator = new Random();
        int magicNumber = randomGenerator.Next(1,11);

        //Console.WriteLine("What is the macic number?");
        //Console.WriteLine("What is the guess");
        int magicNumber = int.Parse(Console.ReadLine());
        

       // Random randomGenerator = new Random();
       // int number = randomGenerator.Next(1,11);
        
        int guess  = 1;
       
       while (guess != magicNumber)
       {
        Console.Write("What is your guess");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }

        else if (magicNumber < guess)

        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("You guessed it!");
        }

       }



    }





}