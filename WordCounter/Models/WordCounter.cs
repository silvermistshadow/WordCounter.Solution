using System;
using System.Linq;
using System.Collections.Generic;

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

        public bool sentenceMatch() //This only returns whether a match exists- another will actually count how many matches exist
        {
            string[] split = this.Sentence.Split(' ');
            for(int i = 0; i<split.Length; i++)
            {
                split[i] = RemoveNonLetter(split[i]);
            }
            return Array.Exists(split, element => element == Word);
        }

        public int matchCount()
        {
            string[] split = this.Sentence.Split(' ');
            int matchCount = 0;
            for(int i = 0; i<split.Length; i++)
            {
                split[i] = RemoveNonLetter(split[i]);
                if (split[i] == Word)
                {
                    matchCount += 1;
                }
            }
            return matchCount;
        }

        public string RemoveNonLetter(string input)
        {
            return new string(input.ToCharArray()
            .Where(c => char.IsLetter(c))
            .ToArray());
        }
    }
}