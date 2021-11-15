using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserSetField
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
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
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
