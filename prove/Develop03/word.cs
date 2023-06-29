using System;

namespace DailyScripture
{
  class Word
    {
        private string _text; 
        private bool _IsHidden; 

        public Word(string text)
        {
          this._text =text;
            _IsHidden = false;
        }

        public void Hide() 
        {
            _IsHidden = true;
        }
        public string  GetText()
        { 
            return _text;
        }

        public bool IsHidden()
        {
            return _IsHidden;
        }


    }

    

}

