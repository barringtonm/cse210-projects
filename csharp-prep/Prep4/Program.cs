using System;

class Program
{
    static void Main(string[] args)
   
    {
   

        Console.WriteLine("What is the macic number?");
        Console.WriteLine("What is the guess");
        int magicNumber = int.Parse(Console.ReadLine());
        

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
        
        int guess  = 1;
       
       while (guess ! = magicNumber)
       {
        
       }
    }
}