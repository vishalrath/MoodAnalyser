using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUc4;
using System;

namespace MSTestProject
{
    [TestClass]
    public class UnitTest1
    { 
        MoodAnalyseReflection factory = null;

        [TestMethod]
        [TestCategory("Reflection")]
        public void ReflectionUsingDefaultConstructor()
        {
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                obj = factory.createMoodAnalyserObject("MoodAnalyserUc4.MoodAnalyser", "MoodAnalyser");

            }
            catch (CustomException exception)
            {
                throw new Exception(exception.Message);
            }
            obj.Equals(expected);
        }
    }
}
