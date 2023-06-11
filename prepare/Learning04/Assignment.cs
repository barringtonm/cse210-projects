using systems;
    
       public class Assignment
    {
        private string _studentName;
        private string _topic;

        public Assignment(string _studentName, string topic)
        {
            _studentName = _studentName;
            _topic = topic;
        }

        public string GetstudentName()
        {
            return _studentName;
        }
                        
        
         public string Gettopic()
        {
            return _topic;

        }

        public string GetSummary() 
        {
            return _studentName + " - " + _topic;
        }
    }
        
    
        
        
        

    
        
