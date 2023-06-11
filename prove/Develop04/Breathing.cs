using systems;
//Derive class
public class BreathingtingActivity : MindFulnessProgram
{
    public BreathingtingActivity() :base("Breathing Activity", "This activity will help" +
        " you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")

    {

    }

    public override void Start()
    {
        Console.WriteLine($" Starting {name} ...");
        Console.WriteLine(description);
        SetDuration();
        Console.WriteLine("Prepare to begin ...");
        Pause(3);
        PerformActivity(BreathingtingActivity);
        Console.WriteLine($"You have completed {name} for {duration} seconds.");
        Pause(3);
    }
    private void PerformBreathingActivity()
    {
        Console.WriteLine("Let's start breathing...");
        for (int i = 0; i < duration; i+= 2)
        {
            Console.WriteLine("Breathe in ...");
            Pause(2);
            Console.WriteLine("Breathe out...");
            Pause(2);
        }
    }



}



    

