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
            bool result = testLetter.letterMatch();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WordCounter_SingleLetterNonMatch_False()
        {
            //Arrange
             RepeatCounter testLetter = new RepeatCounter('a', 'b');
            //Act
            bool result = testLetter.letterMatch();
            //Assert
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void WordCounter_SingleLetterCapitalMatch_True()
        {
            //Arrange
            RepeatCounter testCapital = new RepeatCounter('a', 'A');
            //Act
            bool result = testCapital.letterMatch();
            //Assert
            Assert.AreEqual(result, true);
        }
        
    }
}