using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUc6;
using System;

namespace MsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyserFactoryRefeclection factory = null;

        [TestInitialize]
        public void SetUp()
        {
            factory = new MoodAnalyserFactoryRefeclection();
        }

        [TestMethod]
        public void AnalyseHappyMood()
        {
            // Test Case 1
            //Arrange
            string message = null;
            string expected = "happy";

            //Act
            MoodAnalyser modeAnalyzer = new MoodAnalyser(message);
            string actual = modeAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void getCustomNullException()
        {
            //Arrange
            string expected = "Message Should Not Be Null";
            MoodAnalyser modeAnalyzer = new MoodAnalyser(null);

            try
            {
                //Act
                string actual = modeAnalyzer.AnalyseMood();

            }
            catch (CustomException ex)
            {

                //Assart
                Assert.AreEqual(expected, ex.Message);
            }

        }

        /// <summary>
        /// UC4
        /// Reflections the using default constructor.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        public void ReflectionUsingDefaultConstructor()
        {
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                obj = factory.createMoodAnalyserObject("MoodAnalyzarProblem.ModeAnalyzer", "ModeAnalyzer");

            }
            catch (CustomException ex1)
            {
                throw new Exception(ex1.Message);
            }
            obj.Equals(expected);
        }

        /// <summary>
        /// UC5
        /// Gets the mood analyser using parametre constructor.
        /// TC5.1
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        public void getMoodAnalyserUsingParametreConstructor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactoryRefeclection factory = new MoodAnalyserFactoryRefeclection();
                //act
                actual = factory.CreateMoodAnalyserParameterObject("ModeAnalyzer", "ModeAnalyzer", message);

            }
            catch (CustomException exception)
            {
                throw new Exception(exception.Message);
            }
            actual.Equals(expected);
        }

        /// <summary>
        /// Gets the mood analyser using parametre constructor1.
        /// UC5 
        /// TC5.2 Pass wrong class name
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        public void getMoodAnalyserUsingParametreConstructorPassWrongClassName()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactoryRefeclection factory = new MoodAnalyserFactoryRefeclection();
                //act
                actual = factory.CreateMoodAnalyserParameterObject("ModeAnalyzer123", "ModeAnalyzer", message);

            }
            catch (CustomException exception)
            {
                throw new Exception(exception.Message);
            }
            actual.Equals(expected);
        }

        /// <summary>
        /// Gets the mood analyser using parametre constructor pass wrong constructor.
        ///  UC5  TC5.3
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        public void getMoodAnalyserUsingParametreConstructorPassWrongConstructor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactoryRefeclection factory = new MoodAnalyserFactoryRefeclection();
                //act
                actual = factory.CreateMoodAnalyserParameterObject("ModeAnalyzer", "ModeAnalyzerconstrcutor", message);

            }
            catch (CustomException exception)
            {
                throw new Exception(exception.Message);
            }
            actual.Equals(expected);
        }

        [TestMethod]
        public void testMoodAlalyserUisngInvokeMethod()
        {
            string message = "Happy";
            string methodName = "AnalyseMood";
            string expected = "Happy";
            string actual = " ";
            try
            {
                MoodAnalyserFactoryRefeclection factory = new MoodAnalyserFactoryRefeclection();

                actual = factory.InvokeAnalyserMethod(message, methodName);
            }
            catch (CustomException exception)
            {
                throw new Exception(exception.Message);

            }
            Assert.AreEqual(expected, actual);

        }

    }
}
