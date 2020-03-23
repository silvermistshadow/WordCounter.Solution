using System;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        
        public string Word { get; set; }
        public string Sentence { get; set; }
        public char Letter { get; set; }
        public char CheckLetter { get; set; }
        
        public RepeatCounter(char input, char letterToCheck)
        {
            Letter = Char.ToLower(input);
            CheckLetter = Char.ToLower(letterToCheck);
        }

        public RepeatCounter(string input, string inputSentence)
        {
            Word = input.ToLower();
            Word = RemoveNonLetter(Word);
            Sentence = inputSentence.ToLower();
        }

        public bool letterMatch()
        {
            if (this.Letter == this.CheckLetter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool wordMatch()
        {
            if (this.Word == this.Sentence)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         public string RemoveNonLetter(string input)
        {
            return new string(input.ToCharArray()
            .Where(c => char.IsLetter(c))
            .ToArray());
        }
    }
}