using System;
using WordCounter.Models;

namespace WordCounter
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("This program takes a word and a sentence and tells how many times a word is repeated.");
            Console.WriteLine("First, please enter the word:");
            string inputWord = Console.ReadLine();
            Console.WriteLine("Next, please enter the sentence:");
            string inputSentence = Console.ReadLine();
            RepeatCounter repeat = new RepeatCounter(inputWord, inputSentence);
            Console.WriteLine("There were {0} matches", repeat.MatchCount());
        }
    }
}