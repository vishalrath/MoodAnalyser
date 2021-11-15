using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUc2;

namespace Mstest
{
    [TestClass]
    public class UnitTest1  //here performed the unit testing for class
    {
        [TestMethod]
        public void AnalyseHappyMood() //here performed the unit testing for method
        {

            //Arrange
            string message = "I am in sad mood";
            string expected = "SAD";

            //Act
            MoodAnalyser modeAnalyzer = new MoodAnalyser(message);
            string actual = modeAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
