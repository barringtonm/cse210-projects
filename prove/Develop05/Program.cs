using System;
namespace Development5 
{


        class Program
    {
    private const bool V = false;
    private const int V1 = 6;

    static void Main(string[] args, bool quit)
    {
        Menu menu= new Menu();
        List<string> list= new List<string> ();
        {
        
            "Menu Options: "",
            "1.Create New Goal",
            "2.List Goals",
            "3.Save Goals",
            "4.Load Goals",
            "5.Record Event",
            "6. Quit"    

    
        };

        while (!quit) 
        {
            Console.WriteLine("\n Welcome to the Eternal Quest program");

            Console.WriteLine("Select a choice from the menu: ");

            Console.WriteLine("1.Create New Goal");

            Console.WriteLine("2.List Goals");

            Console.WriteLine("3.Save Goals");

            Console.WriteLine("4.Load Goals");

            Console.WriteLine("5.Record Event");

            Console.WriteLine("6.Quit");
            
            Console.WriteLine("\nWhat would you like to do? ");

        }


            string choice = ConstructorBuilder.ReadLine();

            createGoal(simpleGoals, eternalgoals)

            {
               Console.WriteLine($" simpleGoals=10 points, eternalGoals=100 points");
            }

            FileSystemSecurity.io.File.ReadLines(simpleGoals, etrnalGoals)
            {
                static string  GetRandomPrompt(List<string>inputs) 
                {
                    Random random = new Random();
                    int index = random.Next(inputs.Count);
                     return inputs[index];
                }

                string filename = "Goals.txt";
                string[] lines = FileSystemAclExtensions.io.File.ReadLines(filename);
                {
                    foreach (string line in lines)

                    string firstName = parts[0];
                    string LastName = parts[1]; 
                }
            }


        
            Console.WriteLine("Welcome to the program!");

            switch (choice) 
            { 
            case "1":
            string prompt = GetRandomPrompt(prompt);
            menu.AddEntry(prompt);
            break;
            case "2":
            menu.DisplayEntries();
            break;
            case "3":
            menu.SaveToFile(Goals.txt);
            break;
            case "4":
            menu.LoadFromFile();
            break;
            case "5":
            quit = true;
            break;
            default:
            Console.WriteLine("Invalid choice.");
            break;
            }




            Console.WriteLine("let us start over!");

           static string GetRandomPrompt(List<string>prompts) 
         {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
         }

    }


    




}
