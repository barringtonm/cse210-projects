using Systems;
namespace Foundation4Pol 
{
     public class Activity // Base 
        {
        protected string _date;
        protected int _minutes;
        protected string _name;

        
        }
       public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }
        public virtual double CalculateDistance() 
        {
            return 0;
        }

        public virtual double CalculateSpeed() 
        {
            return 0;
        }
        public virtual double CalculatePace()
        {
            return 0;
        }

        public virtual void GetSummary(); 
        
                public virtual string GetSummary()
            {
                string summary = $"{_date} {_name} ({_minutes} min )- Distance {CalculateDistance()} km, Speed: {CalculateSpeed()} kph,Pace:{CalculatePace()}  min per km";
                
                 return summary;
            } 
            

}