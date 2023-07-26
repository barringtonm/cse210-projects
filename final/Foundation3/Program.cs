using System;
namespace Foundation4I
{
    class Program
    {
        static void Main(string[] args)
        {

            standardEvent standardEvent = new standardEvent();

            standardEvent.eventTitle("AI Lecture");
            {
                Console.WriteLine($"Event Tile :AI Lecture");
            }

            standardEvent.eventType("Workshop");
            {
                Console.WriteLine("The AI Lecture is a workshop Course");
            }



            fullDetailsEventullDetailsEvent fullDetailsEvent = new fullDetailsEvent();

            fullDetailsEvent.speakerName("John Artificial Intelligence"); 
            {
                Console.WriteLine("The AI Lecture is a Workshop course facilitated by John Artificial Intelligence");
            }











            shortDescriptionEvent shortDescriptionEvent = new shortDescriptionEvent();

            shortDescriptionEvent.date();
            {
                object value = Console.WriteLine("The AI Lecture is a Workshop course facilitated by John Artificial Intelligence is on Feburuary 10, 2025.");
            }




















            //Console.WriteLine("");
        }
    }
}
