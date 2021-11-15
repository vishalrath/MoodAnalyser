using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserSetField
{
    public class CustomException:Exception
    {
        public ExceptionType type; //   // created a veriable of type   
        public enum ExceptionType
        {
            NUll_Type_Exception,
            Empty_Type_Exception,  // define some enum values by use the custom exception here
            Class_Not_Found,
            CONSTRUCTOR_NOT_FOUND,
            No_Such_Method,
            Field_Null,
            Null_Message,
            EMPTY_MESSAGE

        }

        // parameterise constructer set the exception type ane message
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
