using System;
using System.Linq;

// A code template for the category of things known as 
public class WordInScripture
{
    // Variables
    public string _wordsInScripture = "";
    public string _ref = "";
    public string[] _result;
    public List<int> _hidden;

    // Methods
    public WordInScripture()
    {
    }
    public WordInScripture(string text, string visible)
    {

    }
    public void GetRenderedText(Scripture scripture)
    {
        var _wordInScripture = scripture._scriptureText;
        _result = _words.Split(" ");
        _hidden = new List<int>();
    }
    public void GetRenderedRef(Scripture scripture)
    {
    }

    public void Show(string ref1)
    {
       _ref = ref1;
        Console.Clear();
        Console.Write("\n**** Press spacebar or enter to hide words ****");
        Console.Write("\n**** Press Q to Quit ****\n");
        // Console.Write($"{_hidden.Count}, {_result.Length}\n");
        Console.WriteLine($"{_ref}");
        for (var i = 0; i < _result.Length; i++)
        {
            var str = _result[i];
            int len = str.Length;
            string dashedLine = new String('_', len);
            if (_hidden.Contains(i))
            {
                Console.Write($"{dashedLine} ");
            }
            else
            {
                Console.Write($"{str} ");
            }
        }
    }

    public void GetReadKey()
    {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            GetNewHiddenWordInScripture();
            // GetNewHiddenWordInScripture();
        }
        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }
    }
    public void GetNewHiddenWordInScripture()
    {
        // var cap = _hidden.Capacity;
        // cap = _result.Length;
        var random = new Random();
        var index1 = random.Next(_result.Length);
        var index2 = random.Next(_result.Length);
        if (_hidden.Contains(index1) || _hidden.Contains(index2))
        {
            GetNewHiddenWordInScripture();
        }
        else
        {
            _hidden.Add(index1);
            _hidden.Add(index2);

        }
    }


}
