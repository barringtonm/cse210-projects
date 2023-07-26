using System;
using System.Collections.Generic;
namespace foundationfourA
{
    public class Video
    {
        public string _name;
        public string _author;
        public int _durationInSeconds;
        public List<Comment> _comments = new List<Comment>();

        public Video()
        {

        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOFComments()
        {
            return _comments.Count;
        }

        public void Display()
        {
            Console.WriteLine("Video: " + _name);
            Console.WriteLine("Author: " + _author);
            Console.WriteLine("Duration: " + _durationInSeconds + " seconds");
            Console.WriteLine("Comments: " + GetNumberOFComments());
            foreach (Comment comment in _comments)
            {
                comment.Display();
            }
        }
    }
}