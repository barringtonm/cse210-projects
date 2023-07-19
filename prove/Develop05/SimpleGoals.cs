using System;
namespace Development5
 {
      public class  SimpleGoals : Goals
   {
    
   private string _simpleGoalName;
   private string _menuOptions;

   public SimpleGoals(string simpleGoalName, string _menuOptions):base("goalname, menuOptions")
      
      {
         _simpleGoalName = simpleGoalName;
      }
         public string GetGoalsName() 
         {
            return _simpleGoalName;
         }
         

       




   }

 }
