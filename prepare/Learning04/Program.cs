using System;

class Program
    {
        static void Main(string[] args)
        {
            //base Assignment
            Assignment b6 =new Assignment("Barry Winter", "Division");
            Console.WriteLine(b6.GetSummary());
            //Derive class Assignments  
            MathAssignment b7 =new MathAssignment("Silvanus Thompson F.R.S.","Calculus Made Easy", "On Relative Growing",  "3.0", "1-14");
            Console.WriteLine(b7.GetSummary());
            Console.WriteLine(b7.GetHomeworkList());
            
            WritingAssignment b8 =new WritingAssignment("Eric Freeman & Elizabeth Robson","Head First JavaScript Progamming", "Building an App,");
            ConsoleWriteLine(b8.GetSummary());
            Console.WriteLine(b8.GetWritingInformation());
        }  
        
    }
