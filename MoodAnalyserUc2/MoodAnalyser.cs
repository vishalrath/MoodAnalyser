using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUc2
{
     public class MoodAnalyser
    {
        public string message;

        public MoodAnalyser(string message)  //initialising the parameterised constructor
        {
            this.message = message;
        }
        public string AnalyseMood()          //declaring the analyse mood method
        {
            try                             // try and catch block  for exception handling
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch 
            {
                return "happy";
            }
        }

    }
}
