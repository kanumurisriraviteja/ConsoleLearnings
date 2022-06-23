using ConsoleLearnings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            //LearnLinq.LinqOperations();
            // Algorithms();
            //Collections.MainCollections();
            //StringOperations.Operations();
            //InterviewQns interviewQns = new InterviewQns();
            //interviewQns.Qns();
            Console.ReadKey();
        }

        public static void Algorithms()
        {

            string input = string.Empty;
            do
            {
                input = Console.ReadLine().ToString();
                ConsoleLearnings.Algorithms.GenerateSubString(input);
            } while (!string.Equals(input.ToString(), "No", StringComparison.OrdinalIgnoreCase));
            Console.ReadKey();
        }
    }
}
