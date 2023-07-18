using System;
using System.Collections.Generic;
namespace foundationfourA 
{
        public class Comment 
        {
           public string _nameOfPerson{get;set;}
           public string _text{get; set;}

            public Comment(string _text, string _nameOfPerson) 
            {
                _nameOfPerson = nameOfPerson;
                _text = text;
            }

               public void TrackNameOfPerson()
                {
                    _nameOfPerson = "nameOfPerson";
                }

                public void TrackText()
                {
                      _text = text;
                }

              

                

        }       

          
}           


