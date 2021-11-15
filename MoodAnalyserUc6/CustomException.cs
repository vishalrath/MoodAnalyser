﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUc6
{
    public class CustomException:Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            NUll_Type_Exception,
            Empty_Type_Exception,
            Class_Not_Found,
            CONSTRUCTOR_NOT_FOUND,
            No_Such_Method

        }

        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
