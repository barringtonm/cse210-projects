using System;

class Entry
{
    private string _prompt; 
    private string _response;
    private string _date;
    public Entry(string prompt, string response, string entrydate)
    {
        _prompt = prompt;
        _response = response;
        _date = entrydate;
    }
    public string GetPrompt()
    {
        return _prompt;
    } 

    public string GetResponse()
    {
        return _response;
    }

    public  string GetDate()
    
    {
        return _date;
    }

    public override string ToString()

    {
         return $"Date: {_date} - Prompt:  {_prompt} \n{_response}\n";
    } 
}


