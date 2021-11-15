using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUc5;
using System;

namespace MSTestProject
{
        public class UnitTest1  //here performed the unit testing for class
        {

        MoodAnalyserFactoryRefection factory = null;

            [TestInitialize]
            public void SetUp()
            {
                factory = new MoodAnalyserFactoryRefection();
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
                MoodAnalyserFactoryRefection factory = new MoodAnalyserFactoryRefection();
                    //act
                    actual = factory.CreateMoodAnalyserParameterObject("MoodAnalyser", "MoodAnalyser", message);

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
                MoodAnalyserFactoryRefection factory = new MoodAnalyserFactoryRefection();
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
            ///  UC5  TC5.5
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
                MoodAnalyserFactoryRefection factory = new MoodAnalyserFactoryRefection();
                    //act
                    actual = factory.CreateMoodAnalyserParameterObject("ModeAnalyzer", "ModeAnalyzerconstrcutor", message);

                }
                catch (CustomException exception)
                {
                    throw new Exception(exception.Message);
                }
                actual.Equals(expected);
            }
        }
    
}
