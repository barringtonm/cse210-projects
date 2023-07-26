using System;
namespace Foundation4I
{
    public class Lectures : Event //Derived class
    {
        private string _speakerName;
        private string _speakercapacity;
        
        public Lectures(string _speakerName, string _speakerCapacity) 
        {
            _speakerName = _speakerName;
            _speakerCapacity = _speakercapacity;
        }
    }
}