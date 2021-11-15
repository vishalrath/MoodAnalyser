using System;

namespace Mood_Analyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello !");
            Console.WriteLine("\n Welcome to MoodAnalyser Problem..");
            MoodAnalyser modeAnalyzer = new MoodAnalyser();
            modeAnalyzer.AnalyseMood("happy");
            Console.ReadLine();
        }
    }
}
