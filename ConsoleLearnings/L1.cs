using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnings
{
    public static class L1
    {
        static List<int> newlist = new List<int>();
        public static void CollectionsLearnings()
        {
            int[] numbers = { 5, 4, 5, 5, 4, 1, 5, 5, 5, 5, 5, 5, 5, 5 };

            Console.WriteLine("L1");
            IDictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int VARIABLE in numbers)
            {
                if (!dic.ContainsKey(VARIABLE))
                {
                    dic.Add(VARIABLE, numbers.Count(x => x == VARIABLE));

                }
            }
            foreach (var VARIABLE in dic)
            {
                Console.WriteLine(VARIABLE.Key + "is" + VARIABLE.Value);
            }
            Console.WriteLine(dic.Values.Max());
            Console.WriteLine(dic.Keys.Max());


            Console.WriteLine("L2");
            List<int> a = new List<int>() { 1, 1, 1, 2, 2, 2, 3, 4, 5, 6, 8, 8, 8 };
            Console.WriteLine(a.Max());


            Console.WriteLine("L3");
            int oddNumbers = numbers.Count(x => x / 2 == 1);
            Console.WriteLine(oddNumbers);

            Console.ReadKey();
        }

        //public void test() { } A static class should always have static variables.
    }

}

