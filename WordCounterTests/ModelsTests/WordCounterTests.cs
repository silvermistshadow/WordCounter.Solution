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
            WordCounter testLetter = new WordCounter('a', 'a');
            //Act
            
            //Assert
        }
    }
}