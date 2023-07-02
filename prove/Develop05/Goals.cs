using System;
public class Goals
{

    private string _goalName;
    public int _menuOptions;

    public Goals(string _goalName, string menuOptions)
    {
        _goalName = goalName;
        _menuOptions = menuOptions;
    }  
    public string Goals.GetGoalsName() 
    {
        return _goalName;
    }

    public string GetmenuOptions()
     {
        return _menuOptions;
    }
     public string GetSummary()
     {
        return _goalName + "-" + _menuOptions;
     }

}

