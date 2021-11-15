using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser;

namespace MsTestMoodAnalyser
{
    [TestClass]
    public class MoodAnalyserMsTest  //here performed the unit testing for class
    {
        [TestMethod]
        public void AnalyseHappyMood() //here performed the unit testing for method
        {
            // Test Case 1
            //Arrange
            string message = "I am in sad mood";
            string expected = "SAD";

            //Act
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            string actual = moodAnalyzer.AnalyseMood(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
