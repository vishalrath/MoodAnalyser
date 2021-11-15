using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUc3
{
   public class CustomException: Exception
    {
        public ExceptionType type;
        // enum for Exception type
        public enum ExceptionType
        {
            NUll_Type_Exception,     // define some enum values by use the custom exception here
            Empty_Type_Exception,
            Class_Not_Found

        }
       // created a veriable of type   
         private readOnly ExcepttionType type;

       // parameterise constructer set the exception type ane message
     

        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
