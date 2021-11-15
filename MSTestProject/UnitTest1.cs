using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUc3;

namespace MSTestProject
{
    [TestClass]
    public class UnitTest1  //here performed the unit testing for class
    { 
    public void AnalyseHappyMood()  //here performed the unit testing for method
    {
        // Test Case 1
        //Arrange
        string message = null;
        string expected = "happy";

            //Act
            MoodAnalyser moodeAnalyser = new MoodAnalyser(message);
        string actual = moodeAnalyser.AnalyseMood();

        //Assert
        Assert.AreEqual(expected, actual);

    }

        [TestMethod]
        public void getCustomNullException()
        {
            //Arrange
            string expected = "Message Should Not Be Null";
            MoodAnalyser moodeAnalyzer = new MoodAnalyser(null);

            try
            {
                //Act
                string actual = moodeAnalyzer.AnalyseMood();

            }
            catch (CustomException ex)
            {

                //Assart
                Assert.AreEqual(expected, ex.Message);  // it checking the expected message and actual message equal or not
            }
        }

    }
}

