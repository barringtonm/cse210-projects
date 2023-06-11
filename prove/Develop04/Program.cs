using Microsoft.VisualBasic;
using Internal;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Diagnostics;
//Main Program
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");

        while (true)
        {
            Console.WriteLine("Please choose an activity :");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3.Listing Activity");
            Console.WriteLine("4.Done");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();


            Activity activity;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                    case "2":
                    activity = new ReflectingActivity();
                    break;
                    case "3":
                    activity = new ListingActivity();
                    break;
                    case "4":
                    Console.WriteLine("Thank you for using the MindfulnesActivity App. Goodbye!");
                    return;
                    default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    continue;
            }

            activity.Start();

    
            Console.WriteLine();
       }




    }



      
}   
