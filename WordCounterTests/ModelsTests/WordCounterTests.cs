using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void WordCounter_SingleLetterMatch_True()
        {
            //Arrange
            RepeatCounter testLetter = new RepeatCounter('a', 'a');
            //Act
            bool result = testLetter.LetterMatch();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WordCounter_SingleLetterNonMatch_False()
        {
            //Arrange
             RepeatCounter testLetter = new RepeatCounter('a', 'b');
            //Act
            bool result = testLetter.LetterMatch();
            //Assert
            Assert.AreEqual(result, false);
        }
        
        [TestMethod]
        public void WordCounter_SingleLetterCapitalMatch_True()
        {
            //Arrange
            RepeatCounter testCapital = new RepeatCounter('a', 'A');
            //Act
            bool result = testCapital.LetterMatch();
            //Assert
            Assert.AreEqual(result, true);
        }
        
        [TestMethod]
        public void WordCounter_SingleWordMatch_True()
        {
            //Arrange
            RepeatCounter testWord = new RepeatCounter("cat", "cat");
            //Act
            bool result = testWord.WordMatch();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WordCounter_SingleWordCapMatch_True()
        {
            //Arrange
            RepeatCounter testCapitalWord = new RepeatCounter("cat", "CAT");
            //Act
            bool result = testCapitalWord.WordMatch();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WordCounter_SingleWordNonMatch_False()
        {   
            //Arrange
            RepeatCounter testWord = new RepeatCounter("cat", "dog");
            //Act
            bool result = testWord.WordMatch();
            //Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void WordCounter_SingleWordIgnoreWhitespace_true()
        {
            //Arrange
            RepeatCounter testWord = new RepeatCounter("c at", "cat");
            //Act
            bool result = testWord.WordMatch();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WordCounter_SingleWordIgnoreNumber_True()
        {
            //Arrange
            RepeatCounter testWord = new RepeatCounter("c3at", "cat");
            //Act
            bool result = testWord.WordMatch();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WordCounter_SingleWordIgnorePunct_True()
        {
            //Arrange
            RepeatCounter testWord = new RepeatCounter("Cat.", "cat");
            //Act
            bool result = testWord.WordMatch();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WordCounter_SingleWordIgnorePartial_False()
        {
            //Arrange
            RepeatCounter testWord = new RepeatCounter("cat", "cathedral");
            //Act
            bool result = testWord.WordMatch();
            //Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void WordCounter_SentenceMatch_True()
        {
            //Arrange
            RepeatCounter testSentence = new RepeatCounter("fox", "The quick brown fox jumped over the lazy dog");
            //Act
            bool result = testSentence.SentenceMatch();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void RepeatCounter_GetMatches_2()
        {   
            //Arrange
            RepeatCounter testSentence = new RepeatCounter("poop", "How many poops did the cat leave in the poop box, it was already full of POOP.");
            //Act
            int result = testSentence.MatchCount();
            //Assert
            Assert.AreEqual(result, 2);
        }
    }
}