using System;
using System.Linq;

namespace WordCounter
{
    public class WordCounter
    {
        
        public string word { get; set; } = "";
        public string sentence { get; set; } = "";
        public char letter { get; set; } = ' ';
        public char checkLetter { get; set; } = ' ';
        public WordCounter(char input, char letterToCheck)
        {
            letter = Char.ToLower(input);
            checkLetter = Char.ToLower(letterToCheck);
        }

        public WordCounter(string input, string inputSentence)
        {
            word = input.ToLower();
            word = RemoveNonLetter(word);
            sentence = inputSentence.ToLower();
            sentence = RemoveNonLetter(sentence);
        }


         public string RemoveNonLetter(string input)
        {
            return new string(input.ToCharArray()
            .Where(c => char.IsLetter(c))
            .ToArray());
        }
    }
}