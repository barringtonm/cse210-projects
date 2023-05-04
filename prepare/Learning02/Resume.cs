using System;

public class Resume
{
    
        

        public string _name;
        public List<Job>  = new List<job>();
        public void Display()

        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("jobs:");

            foreach (Job job in _jobs)
            {
                job.Display();
            } 
        }



    
}