using System;
namespace Development5 
{
     public class EternalGoals : Goals
{
    private string _eternalgoalName;
    public int _menuOptions;
    public EternalGoals(string _eternalgoalName, string _menuOptions):base(goalName, menuOptions)

    _eternalGoalName = eternalGoalName;
    _menuOptions = menuOptions;
    }  
    public string GetGoalsNameList() 
    {
    return _goalName;
    }   
    private  string GetWritingInformation()
    {
    return _menuOptions;
    }
    private string GetSummary()
    {
    return _eternalGoalName + "-" + _menuOptions;
    }
        

   
}




