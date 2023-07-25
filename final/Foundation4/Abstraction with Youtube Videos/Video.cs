using System;
using System.Collections.Generic;
namespace foundationfourA
{
    public class Video 
    {
        public Video(string _name, int _durationInSeconds) 
        {
          this._name = name;
         this._durationInSeconds = durationInSeconds;
   
        }
          public string _name{get;set;}
         public string _author{get; set;}
         public int _durationInSeconds{get; set;}

        private List<Comment> comments;
        public Video(string _videoTitle, string _author, int _durationInSeconds)
        {
            _videoTitle = videoTitle;
            _author = author;
            _durationInSeconds = durationInSeconds;

        }

        public void  AddComment(Comment comment)
        {
            comments.Add(comment); 
        }

        public int GetNumberOFComments() 
        {
            return comments.Count;
        }


        public void TrackVideoTitle  (string name)
        {
            return name;
        }
    

        

        public void TrackNameOfAuthor(string name) 
        {
            return _author;
        }

        public void trackLengthVideo(int lengthInSeconds)
        {
             _lengthInSeconds = lengthInSeconds;
        }
    
                      
            
        

        public void StoreListComments(string[] comments) 
        {
           return;     
        }
    }

      













}     