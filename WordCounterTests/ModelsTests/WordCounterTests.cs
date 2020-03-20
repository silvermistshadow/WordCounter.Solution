using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounterTests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void WordCounter_SingleLetterMatch_True()
        {
            //Arrange
            WordCounter.WordCounter testLetter = new WordCounter.WordCounter('a', 'a');
            //Act
            
            //Assert
        }
    }
}