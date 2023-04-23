using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?" );
        string userInput  = Console.ReadLine();
        int number  = int.Parse(userInput);

        if  ( number >=90)
        {       
            Console.WriteLine("grade A-Pass");

        }
        else if (number>=80)
        {
            Console.WriteLine("grade B-Pass");
        }

        else if (number>=70)
        {
            Console.WriteLine("grade C-pass");
        }

        else if (number>=60)
        {
            Console.WriteLine("grade D-Pass");

        }

        else 
        {
            Console.WriteLine("grade F-Fail, keep working");
        }
         

    }       
 
        
}