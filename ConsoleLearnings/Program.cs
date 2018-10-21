using ConsoleLearnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {

        static void Main(string[] args)
        {
            // Algorithms();
            //LCollections.MainCollections();
            //StringOperations.Operations();
            //InterviewQns interviewQns = new InterviewQns();
            //interviewQns.Qns();
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
