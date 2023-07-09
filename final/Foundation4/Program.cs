using System;
using System.Collections.Generic;

namespace foundationfour
{        public class Program
    {



        public static void Main(string[] args)

        { 
           Video video1 = new Video();
           video1._videoTitle = "Why helicopters fall like a leaf";
           video1._author = "NotWhatYouThink60";
           video1._durationInSeconds = 802;

           Comment comment1 = new Comment();
           comment1._nameOfPerson = "@noonekows352";
           comment1._text = "When.. happen in tail rotor ";

           Comment comment2 = new Comment();  
           comment2._nameOfPerson ="@ilovetinggyun";
           comment2._text = "The way I try to describe autoratio lower the blade"; 

           Comment comment3  = new Comment();
           comment3._nameOfPerson = "@mouseer485";
           comment3._text = "Why don't helicopters land like a rock .. engine dies?";   


           string [] comments ={"comment1", "comment2", "comment3" };
           List<string>commentsList = new List<string>();
           commentsList.AddRange(comments);
           foreach (string a in commentsList)
           Console.WriteLine(a);



           Video video2 = new Video();
           video2._videoTitle = "Building a workbench from an old power pole";
           video2._author ="The Dusty Lumber Co";
           video2._durationinSeconds = 835;    

           Comment comment1 = new Comment();
           comment1._nameOfPerson = "@desertpillar5286";
           comment1._text = "And on this table, they built the rest of the house"; 
            
           Comment comment2 = new Comment();  
           comment2._nameOfPerson ="@DominicDore";
           comment2._text = "Beautiful piece!..";
           Comment comment3  = new Comment();
           comment3._nameOfPerson = "@deosiewilson732";
           comment3._text = "That was amzing to watch..";   

           string [] comments ={"comment1", "comment2", "comment3" };
           List<string>commentsList = new List<string>();
           commentsList.AddRange(comments);
           foreach (string a in commentsList)
           Console.WriteLine(a);



           video video3 = new Video();
           video3._videoTitle = "What happens when a submarine implodes";
           video3._author = "NotWhatYouThink60";
           video3._durationinSeconds = 835;

           string [] comments ={"comment1", "comment2", "comment3" };
           List<string>commentsList = new List<string>();
           commentsList.AddRange(comments);
           foreach (string a in commentsList)
                Console.WriteLine(a);


            Comment comment1 = new Comment();
            comment1._nameOfPerson = "@peekaboo4390";
            comment1._text = "My dad was a cold war submarine captain and his greatest fear was to sink to implosion depth";

            comment comment2 = new Comment();  
            comment2._nameOfPerson ="@danistudwell406";
            comment2._text = "I always heard the term instantaneos Death";

            Comment comment3  = new Comment();
            comment3._nameOfPerson = "@namessurname8812";
            comment3._text = "The Titan imploded instantly without any warning";}
            
            public string _name;
            private List<Video> video = new List<Video>();

            public List<Video> Video { get => video; set => video = value;} 
                
            public void Display()
                {
                    Console.WriteLine($"Name: {_name}");
                    Console.WriteLine("videos");

                    foreach (Video video in _video) 
                    {
                    video.Display();
                                                
                    } 
                }

        }        
                    
}   


          
                
 

    




     







    
                




               

              

