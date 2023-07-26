using System;
using System.Collections.Generic;

namespace foundationfourA
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Video> videos = new List<Video>();

            Video video1 = new Video();
            video1._name = "Why helicopters fall like a leaf";
            video1._author = "NotWhatYouThink60";
            video1._durationInSeconds = 802;

            Comment comment1 = new Comment();
            comment1._nameOfPerson = "@noonekows352";
            comment1._text = "When.. happen in tail rotor ";

            Comment comment2 = new Comment();
            comment2._nameOfPerson = "@ilovetinggyun";
            comment2._text = "The way I try to describe autoratio lower the blade";

            Comment comment3 = new Comment();
            comment3._nameOfPerson = "@mouseer485";
            comment3._text = "Why don't helicopters land like a rock .. engine dies?";

            video1._comments.Add(comment1);
            video1._comments.Add(comment2);
            video1._comments.Add(comment3);

            videos.Add(video1);

            Video video2 = new Video();
            video2._name = "Building a workbench from an old power pole";
            video2._author = "The Dusty Lumber Co";
            video2._durationInSeconds = 835;

            Comment comment4 = new Comment();
            comment4._nameOfPerson = "@desertpillar5286";
            comment4._text = "And on this table, they built the rest of the house";

            Comment comment5 = new Comment();
            comment5._nameOfPerson = "@DominicDore";
            comment5._text = "Beautiful piece!..";

            Comment comment6 = new Comment();
            comment6._nameOfPerson = "@deosiewilson732";
            comment6._text = "That was amzing to watch..";

            video2._comments.Add(comment4);
            video2._comments.Add(comment5);
            video2._comments.Add(comment6);

            videos.Add(video2);

            Video video3 = new Video();
            video3._name = "What happens when a submarine implodes";
            video3._author = "NotWhatYouThink60";
            video3._durationInSeconds = 835;

            Comment comment7 = new Comment();
            comment7._nameOfPerson = "@peekaboo4390";
            comment7._text = "My dad was a cold war submarine captain and his greatest fear was to sink to implosion depth";

            Comment comment8 = new Comment();
            comment8._nameOfPerson = "@danistudwell406";
            comment8._text = "I always heard the term instantaneos Death";

            Comment comment9 = new Comment();
            comment9._nameOfPerson = "@namessurname8812";
            comment9._text = "The Titan imploded instantly without any warning";

            videos.Add(video3);

            foreach (Video video in videos)
            {
                video.Display();
            }

        }
    }
}
