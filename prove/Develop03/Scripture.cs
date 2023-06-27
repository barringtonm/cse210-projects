using System;
namespace DailyScripture
{


    class Scripture
    {

        private Reference reference;
        private List<Word> words;
        public Scripture(string book, int chapter, int verse, string text)
        {
            Reference = new Reference(book, chapter, verse);
            Words = new List<Word>();

            string[] splitText = text.Split(' ');
            foreach (string word in splitter)
            {
                Words.Add(new Word(word));

            }


            List<Word> visibleWords = GetVisibleWords();
            if (visibleWords.Count == 0)
                return;
            {
                Random random = new Random();
                int randomIndex = random.Next(visibleWords.Count);
                visibleWords[randomIndex].Hide();

            }

        }   


            private  List<Word> GetvisibleWords()

            {
                List<Word> visibleWords = new List<Word>();
                foreach (Word word in words)
                {
                    if (!word.IsHidden)
                        visibleWords.Add(word);
                    return visibleWords;
                }
            }
    }





        
    
    }
}  
