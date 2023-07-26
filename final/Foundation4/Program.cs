using System;            
namespace Foundation4Pol
{

    class Program
    {
        static void Main(string[] args)
        {
          List<Activity> activityList = new   List<Activity>();
          Running running = new Running("May 30, 2021" , 25, 3.6);
          activityList.Add(running);

          StationaryBikes stationaryBikes = new StationaryBikes("June 2, 2021", 50, 12);
          activityList.Add(StationaryBikes);

          Swimming swimming = new Swimming("June 10, 2022", 15, 10);
          activityList.Add(swimming);

          Console.WriteLine("Activities: ");
          Console.WriteLine();

          foreach ( Activitiy activity in activityList) 


          {
            Console.WriteLine(exercise.GetSummary());
          }

        }
    }

            
}