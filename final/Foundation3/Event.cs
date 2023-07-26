using System;
namespace Foundation4I
{
    public class Event //Base class
    {
        private string _eventTitle;
        private string _description;
        private string _date;
        private int _time;
        private string _address;
        private string _eventType;
        private string _weatherStatement;
        private string _email;
        private string _speakerCapacity;
        private string _speakerName;

        public StandardEvent(string _eventTitle, string _description, string _date, int _time, string  _address)
         {
            _eventTitle = eventTitle;
            _description =_description;
            _date = date;
            _time =  time;   

         }     

        public FullDetailsEvent(string name, string _description, string _date, int _time, string  _address,  string _speakerName, string _speakerCapacity,string _email, string _weatherStatement ) 
        {
            _eventTitle = eventTitle;
            _description =_description;
            _date = date;
            _time =  time;   
            _address = address;
            _speakerName = speakerName;
            _speakercapacity = speakerCapacity;
            _weatherStatement = weatherStatement;
            _email = email;
            
        }


        public ShortDescriptionEvent(string _eventType, string _eventTitle, string _date)

        {
            _eventType = _eventType;
            _eventTitle = _eventTitle;
            _date = date;
        }
    } 
}