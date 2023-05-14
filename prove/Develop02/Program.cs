using System;
namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            // List of prompts
            List<string> prompts = new List<string>
            {
                "what was the most interesting thing that I did today? ",
                "Who were the most influencial person I met today? ",
                "What scriptures did I read today? ",
                "Did  you felt the Spirit when you read the Scriptures? ",
                "Was my prayers answered today? ",
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nDaily Journal Menu");
                Console.WriteLine("---");
                Console.WriteLine("A. new entry");
                Console.WriteLine("B. Display journal");
                Console.WriteLine("C. Save the journal to a file");
                Console.WriteLine("D. Load the journal from a file");
                Console.WriteLine("E. Quit");


                Console.Write("\nEnter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)

                {
                   case "A":
                        journal.AddEntry(prompts[new Random().Next(prompts.Count)]);
                        break;
                    case "B":
                        journal.DisplayEntries();
                        break;
                    case "C":
                        journal.SaveToFile();
                        break;
                    case "D":
                        journal.LoadFromFile();
                        break;
                    case "E":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("See you later");
        }
    
        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}


                       // Program Diagram 
/*
                           +-----------------+
                           |     Program     |
                           +-----------------+
                           | -journal        |
                           +-----------------+
                                   |
                                   |
                                   |
                       +-----------+-----------+
                       |                       |
                +------+--------+      +-------+-----+
                |  PromptList   |      |     Entry   |
                +---------------+      +-------------+
                | -prompts      |      | -prompt     |
                |               |      | -response   |
                | +get_prompt() |      | -date       |
                +---------------+      +-------------+
                                   |
                                   |
                     +-------------+-------------+
                     |             |             |
           +---------+-----+ +-----+---------+ +------------+
           |   SaveToFile  | |  LoadFromFile | |  Display   |
           +---------------+ +---------------+ +------------+
           | -filename     | | -filename     | | -journal   |
           |               | |               | |            |
           | +save()       | | +load()       | | +display() |
           +---------------+ +---------------+ +------------+     */
