using System;
using System.Collections.Generic;
namespace foundationfourA
{
    public class Comment
    {
        public string _nameOfPerson { get; set; }
        public string _text { get; set; }

        public Comment()
        {

        }

        public Comment(string text, string nameOfPerson)
        {
            _nameOfPerson = nameOfPerson;
            _text = text;
        }

        public void Display()
        {
            Console.WriteLine("Comment: " + _text);
            Console.WriteLine("Author: " + _nameOfPerson);
        }
    }
}