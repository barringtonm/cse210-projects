using System;
namespace DailyScripture

{
   
    {
        static void Main(string[] args) 
        {
            Scripture scripture = new Scripture("John", 17,3,"And this is life eternal, that they might know thee the only true God, and Jesus Christ,whom thou hast sent." );
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWord();
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit to exit.");    
            }

        }
    }

}