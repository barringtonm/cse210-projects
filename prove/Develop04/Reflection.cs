using System;
using System.Collections.Generic;
using System.Threading;
public class ReflectionActivity : Activity
{
    private string[] prompts =
    {
     "Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.",    
     "Think of a time when you did something truly selfless."
    };
    private string[] questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before",
        "How did you get started?",
        "How did it feel when it was complete?",
        "What made this time different than other times when you were not as succesful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity():base(" ReflectionActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life.") 
    {
    }
    public override void Start()
    {
        Console.WriteLine($"Starting {name}...");
        Console.WriteLine(description);
        SetDuration();
        Console.WriteLine("Get ready ...");
        Pause(3);
        
        { 
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {name} for {duration} seconds.");
        Pause(3);
        }

    }

        private void  PeformActivity()
        {
            Random random = new Random();
            int remainingSeconds = duration;

            while (remainingSeconds > 0)
            {
             string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
                showSpinner(3);

                foreach (string question in questions) 
                {
                Console.WriteLine(question);

                 showSpinner(3);
                }
                 remainingSeconds -= 30;
            }

        }

}             
 