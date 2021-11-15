using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
 public string message;      // instance veriable

        public MoodAnalyser(string message)  //initialising the parameterised constructor store the user input massege in instance veriable
        {
            this.message = message;
        }
   public class MoodAnalyser
    {
        public string AnalyseMood(string message)     //initialising the parameterised constructor
        {
            if (message.ToLower().Contains("sad"))    // in the containt statement sad is present the return the SAD
            {
                return "SAD";
            }
            else
                return "HAPPY";
        }

    }
}
