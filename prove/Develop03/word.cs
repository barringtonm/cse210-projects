using System;

namespace DailyScripture
{
  class Word
    {
    public string  Text {get; }
        public bool IsHidden {get; private set; }

        public Word(string text)
        {
            text =text;
            IsHidden = false;
        }

        public void Hide() 
        {
            IsHidden = true;
        }
    }
    

}

