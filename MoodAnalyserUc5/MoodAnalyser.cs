using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUc5
{
   public class MoodAnalyser
    {

        //instance veriabe
        public string message;
        public MoodAnalyser()
        {
            Console.WriteLine("default constructor");
        }

        public MoodAnalyser(string message)    //initialising the parameterised constructor
        {
            this.message = message;
        }
        public string AnalyseMood()    //declaring the analyse mood method
        {
            try                            // try and catch block  for exception handling
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                //this shows that it should not be null. NullREferenceException is a predefined exception class
                throw new CustomException(CustomException.ExceptionType.NUll_Type_Exception, "Message Should Not Be Null");
            }
        }
    }
}
